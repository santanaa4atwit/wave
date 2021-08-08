using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wave2.Classes;

namespace Wave2.Forms
{
    public partial class Support : Form
    {
        public Support()
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

        private void TitleBar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Min_Button_Click(object sender, EventArgs e)
        {
            WindowStates.Minimize(this);
        }

        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void foCUS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
