using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wave2.Classes;

namespace Wave2.Forms
{
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Min_Button_Click(object sender, EventArgs e)
        {
            WindowStates.Minimize(this);
        }

        private void Cross_Button_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
