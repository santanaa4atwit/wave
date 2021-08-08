using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        SQLiteCommand command;
        SQLiteDataAdapter da;
        private BindingSource bindingSource = null;
        private SQLiteCommandBuilder SQLiteCommandBuilder = null;
        DataTable dataTable = new DataTable();

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

            DataBind();

            /*           using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
                       {
                           conn.Open();
                           SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT TrackTitle, Artists, AlbumTitle, AlbumArtists, Genres, DiscNumber, TrackNumber, Year, FilePath FROM Track", conn);
                           DataSet ds = new System.Data.DataSet();

                           da.Fill(ds, "Track");
                           dataGridView1.DataSource = ds.Tables[0];
                       }
           */
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string[] sb = new String[1000];


                using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {

                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            DataGridViewRow row = dataGridView1.SelectedRows[i];
                            sb[i] = row.Cells["FilePath"].Value.ToString();

                            string strSql = $"DELETE FROM Track WHERE FilePath = '{sb[i]}'";
                            cmd.CommandText = strSql;
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                }
            }

            da.Update(dataTable);
            MessageBox.Show("Songs Removed");
            DataBind();

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

                List.AddFiles(sb);
                if (DoClearPlaylist)
                {
                    List.NewPlaylist();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = string.Format("TrackTitle like '%{0}%' or Artists like '%{0}%' or AlbumTitle like '%{0}%' or Genres like '%{0}%' or AlbumArtists like '%{0}%' or Year like '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit(); //very important step
            da.Update(dataTable);
            MessageBox.Show("Songs Updated");
            DataBind();
        }

        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dataTable.Clear();

            String connectionString = "data source = Wave.db";
            String queryString1 = "SELECT * FROM Track";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = queryString1;
            try
            {
                da = new SQLiteDataAdapter(queryString1, connection);
                SQLiteCommandBuilder = new SQLiteCommandBuilder(da);
                da.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            foCUS.Focus();
            AddColumn column = new AddColumn();

            if (column.ShowDialog() == DialogResult.OK)
            {
                da.Update(dataTable);
                MessageBox.Show("Category Added");
                DataBind();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}