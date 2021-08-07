using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wave2.Classes;

namespace Wave2.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool DoClearPlaylist { get; set; }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void TitleBar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }
        private void EliteMediaPlayer_label_Click(object sender, EventArgs e)
        {

        }

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Playlist_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT TrackTitle, Artists, AlbumTitle, AlbumArtists, Genres, DiscNumber, TrackNumber, Year, FilePath FROM Track", conn);
                DataSet ds = new System.Data.DataSet();

                da.Fill(ds, "Track");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string[] sb = new String[1000];

                for (int i = 0; i < selectedRowCount; i++)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[i];
                    sb[i] = row.Cells["FilePath"].Value.ToString();
                }

                List.LoadLibraryPlaylist(sb);
                if (DoClearPlaylist)
                {
                    List.NewPlaylist();
                }
            }
        }

        private void Min_Button_Click(object sender, EventArgs e)
        {
            WindowStates.Minimize(this);
           
        }


        private void Max_Button_Click_1(object sender, EventArgs e)
        {
            WindowStates.Maximize(this, Max_Button);
        }

        private void Cross_Button_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void Play_lebel_Click(object sender, EventArgs e)
        {
            if (DoClearPlaylist)
            {
                List.NewPlaylist();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}