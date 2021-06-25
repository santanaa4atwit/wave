using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wavemp3
{
    public partial class Wave : Form
    {
        public Wave()
        {
            InitializeComponent();
        }
        String[] path, files;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = op.SafeFileNames;
                path = op.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Songs.Items.Add(files[i]);
                }
            }
        }

        private void Wave_Load(object sender, EventArgs e)
        {

        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            media.URL = path[Songs.SelectedIndex];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
