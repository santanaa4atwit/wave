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
    public partial class AddColumn : Form
    {

        public AddColumn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void Cross_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddFiles_btn_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog od = new OpenFileDialog
                {
                    Multiselect = true,
                    //Filter = "Wav(*.wav)|*.wav|Acc(*.aac)|*.aac|Wma(*.wma)|*.wma|Wmv(*.wmv)|*.wmv|Avi(*.avi)|*.avi|Mpg(*.mpg)|*.mpg|Mpeg(*.mpeg)|*.mpeg|M1v(*.m1v)|*.m1v|Mp2(*.mp2)|*.mp2|Mp3(*.mp3)|*.mp3|Mpa(*.mpa)|*.mpa|Mpe(*.mpe)|*.mpe|M3u(*.m3u)|*.m3u|Mp4(*.mp4)|*.mp4|Mov(*.mov)|*.mov|3g2(*.3g2)|*.3g2|3gp2(*.3gp2)|*.3gp2|3gp(*.3gp)|*.3gp|3gpp(*.3gpp)|*.3gpp|M4a(*.m4a)|*.m4a|Cda(*.cda)|*.cda|Aif(*.aif)|*.aif|Aifc(*.aifc)|*.aifc|Aiff(*.aiff)|*.aiff|Mid(*.mid)|*.mid|Midi(*.midi)|*.midi|Rmi(*.rmi)|*.rmi|All files (*.*)|*.*",
                    Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV",
                    DefaultExt = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"
                };

                if (od.ShowDialog() == DialogResult.OK)
                {
                    List.AddToLibrary(od.FileNames);
                    DoClearPlaylist = false;
                }
            }
        }

        private void TitleBar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddFolder_btn_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    List.AddFolder(fb.SelectedPath);
                    DoClearPlaylist = false;
                }
            }
        }

        private void Min_Button_Click(object sender, EventArgs e)
        {
            WindowStates.Minimize(this);
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            WindowStates.Maximize(this, Max_Button);
        }

        private void Cross_Button_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void EliteMediaPlayer_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text;

            if (input == null)
            {
                MessageBox.Show("Value cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        string strSql = $"ALTER TABLE Track ADD '{input}' TEXT NULL";
                        cmd.CommandText = strSql;
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                Close();
            }
        }
    }
}