using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Wave2.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wave2.Classes;

namespace Wave2.Forms
{
    public partial class Library : Form
    {
        SQLiteCommand command;
        SQLiteDataAdapter da;
        private BindingSource bindingSource = null;
        private SQLiteCommandBuilder SQLiteCommandBuilder = null;
        DataTable dataTable = new DataTable();

        public Library()
        {
            InitializeComponent();
            DoClearPlaylist = false;
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
        public void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();

            string[] Names = List.GetListOfNames;

            for (int i = 0; i < Names.Length; i++)
            {
                dataGridView1.Rows.Add((i + 1), Names[i]);
            }

            // Repeat_check.Checked = AutoPlayl.AllowRepitition;
            // Shuffle_check.Checked = AutoPlayl.AllowShuffle;
        }
        public void ClearDataGrid()
        {
            //dataGridView1.DataSource = true;
            //dataGridView1.DataBind();
            //dataGridView1.DataSource = null;
           // dataTable.Clear();

            //dataGridView1.Rows.Clear();

            //Repeat_check.Checked = AutoPlayl.AllowRepitition;
            //Shuffle_check.Checked = AutoPlayl.AllowShuffle;
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

                List.NewPlaylist();
                List.AddFiles(sb);

                if (DoClearPlaylist)
                {
                    List.NewPlaylist();
                }
                //ClearDataGrid();
                 //dataGridView1.Rows.Clear();

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

                String query = "";

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i == 5 || i == 6)
                    {
                        query += "";
                    }
                    else
                    {
                        query += String.Format("{0} like '%{1}%'", dataGridView1.Columns[i].HeaderText, textBox1.Text);
                        if (i != dataGridView1.ColumnCount - 1)
                        {
                            query += " or ";
                        }
                    }
                }

                dv.RowFilter = query;
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

        public void DataBind()
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

        private void button4_Click(object sender, EventArgs e)
        {

            int column = dataGridView1.CurrentCell.OwningColumn.Index;

            if (column <= 8)
            {
                MessageBox.Show("Cannot delete standard categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Delete '{dataGridView1.CurrentCell.OwningColumn.Name}'?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {

                            string strSql = $"ALTER TABLE Track DROP COLUMN '{dataGridView1.CurrentCell.OwningColumn.Name}'";
                            cmd.CommandText = strSql;
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                    da.Update(dataTable);
                    MessageBox.Show("Column Removed");
                    DataBind();
                }
            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Deletion_cms.Show(MousePosition);
            }
        }
        private void delete_cmsBtn_Click(object sender, EventArgs e)
        {
            List<string> parameters = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                parameters.Add(item.Cells["AudioNames"].Value.ToString());
            }
            List.RemoveItems(parameters.ToArray());
            UpdateDataGrid();
        }
        

        private void TitleBar_panel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void TitleBar_panel_MouseMove_2(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }
    }
}