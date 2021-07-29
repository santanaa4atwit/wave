namespace Wave2.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainControl_panel = new System.Windows.Forms.Panel();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.Replay_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.PlayPause_btn = new System.Windows.Forms.Button();
            this.BelowPanel = new System.Windows.Forms.Panel();
            this.Volume_trackBar = new System.Windows.Forms.TrackBar();
            this.Volume_btn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Main_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenMedia_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlaylist_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.audioPlayerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_option_cms = new System.Windows.Forms.ToolStripMenuItem();
            this.Video_panel = new System.Windows.Forms.Panel();
            this.Playlist_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewPlayLBtn = new System.Windows.Forms.Button();
            this.TrackBar = new ColorSlider.ColorSlider();
            this.Player_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.PinIcon_btn = new System.Windows.Forms.Button();
            this.Logo_pbox = new System.Windows.Forms.PictureBox();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Min_Button = new System.Windows.Forms.Button();
            this.Max_Button = new System.Windows.Forms.Button();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.childpanel = new System.Windows.Forms.Panel();
            this.panelWave = new System.Windows.Forms.Panel();
            this.MainControl_panel.SuspendLayout();
            this.BelowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).BeginInit();
            this.Main_cms.SuspendLayout();
            this.Video_panel.SuspendLayout();
            this.Playlist_FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).BeginInit();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).BeginInit();
            this.childpanel.SuspendLayout();
            this.panelWave.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl_panel
            // 
            this.MainControl_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MainControl_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainControl_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainControl_panel.Controls.Add(this.Previous_btn);
            this.MainControl_panel.Controls.Add(this.Replay_btn);
            this.MainControl_panel.Controls.Add(this.Next_btn);
            this.MainControl_panel.Controls.Add(this.Stop_btn);
            this.MainControl_panel.Controls.Add(this.PlayPause_btn);
            this.MainControl_panel.Location = new System.Drawing.Point(360, -2);
            this.MainControl_panel.Margin = new System.Windows.Forms.Padding(0);
            this.MainControl_panel.Name = "MainControl_panel";
            this.MainControl_panel.Size = new System.Drawing.Size(300, 58);
            this.MainControl_panel.TabIndex = 0;
            this.MainControl_panel.Click += new System.EventHandler(this.MainControl_panel_Click);
            this.MainControl_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainControl_panel_Paint);
            // 
            // Previous_btn
            // 
            this.Previous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Previous_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Previous_btn.FlatAppearance.BorderSize = 0;
            this.Previous_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Previous_btn.Location = new System.Drawing.Point(72, -11);
            this.Previous_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(52, 75);
            this.Previous_btn.TabIndex = 12;
            this.Previous_btn.TabStop = false;
            this.Previous_btn.Text = "⏮";
            this.Previous_btn.UseVisualStyleBackColor = false;
            this.Previous_btn.Click += new System.EventHandler(this.Previous_btn_Click);
            this.Previous_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Previous_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Replay_btn
            // 
            this.Replay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Replay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Replay_btn.FlatAppearance.BorderSize = 0;
            this.Replay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replay_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F);
            this.Replay_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Replay_btn.Location = new System.Drawing.Point(0, -7);
            this.Replay_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(52, 75);
            this.Replay_btn.TabIndex = 11;
            this.Replay_btn.TabStop = false;
            this.Replay_btn.Text = "⟲";
            this.Replay_btn.UseVisualStyleBackColor = false;
            this.Replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            this.Replay_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Replay_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next_btn.FlatAppearance.BorderSize = 0;
            this.Next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next_btn.Location = new System.Drawing.Point(188, -11);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(52, 75);
            this.Next_btn.TabIndex = 10;
            this.Next_btn.TabStop = false;
            this.Next_btn.Text = "⏭ ";
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            this.Next_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Next_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stop_btn.FlatAppearance.BorderSize = 0;
            this.Stop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.Stop_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Stop_btn.Location = new System.Drawing.Point(248, -9);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(52, 75);
            this.Stop_btn.TabIndex = 9;
            this.Stop_btn.TabStop = false;
            this.Stop_btn.Text = "⏹";
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            this.Stop_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.Stop_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // PlayPause_btn
            // 
            this.PlayPause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayPause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayPause_btn.FlatAppearance.BorderSize = 0;
            this.PlayPause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.PlayPause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPause_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPause_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayPause_btn.Location = new System.Drawing.Point(124, -11);
            this.PlayPause_btn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayPause_btn.Name = "PlayPause_btn";
            this.PlayPause_btn.Size = new System.Drawing.Size(52, 75);
            this.PlayPause_btn.TabIndex = 8;
            this.PlayPause_btn.TabStop = false;
            this.PlayPause_btn.Text = "▶ ";
            this.PlayPause_btn.UseVisualStyleBackColor = false;
            this.PlayPause_btn.Click += new System.EventHandler(this.PlayPause_btn_Click);
            this.PlayPause_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomMain_btn_MouseDown);
            this.PlayPause_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // BelowPanel
            // 
            this.BelowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BelowPanel.Controls.Add(this.Volume_trackBar);
            this.BelowPanel.Controls.Add(this.Volume_btn);
            this.BelowPanel.Controls.Add(this.FullscreenBtn);
            this.BelowPanel.Controls.Add(this.MainControl_panel);
            this.BelowPanel.Location = new System.Drawing.Point(-2, 542);
            this.BelowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BelowPanel.Name = "BelowPanel";
            this.BelowPanel.Size = new System.Drawing.Size(1019, 61);
            this.BelowPanel.TabIndex = 3;
            this.BelowPanel.Click += new System.EventHandler(this.HidePlaylist_OnClick);
            this.BelowPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // Volume_trackBar
            // 
            this.Volume_trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_trackBar.AutoSize = false;
            this.Volume_trackBar.LargeChange = 10;
            this.Volume_trackBar.Location = new System.Drawing.Point(53, 14);
            this.Volume_trackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Volume_trackBar.Maximum = 100;
            this.Volume_trackBar.Name = "Volume_trackBar";
            this.Volume_trackBar.Size = new System.Drawing.Size(150, 42);
            this.Volume_trackBar.TabIndex = 8;
            this.Volume_trackBar.TabStop = false;
            this.Volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume_trackBar.Value = 100;
            this.Volume_trackBar.Scroll += new System.EventHandler(this.Volume_trackBar_Scroll);
            this.Volume_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Volume_btn
            // 
            this.Volume_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Volume_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Volume_btn.FlatAppearance.BorderSize = 0;
            this.Volume_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.Volume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Volume_btn.Location = new System.Drawing.Point(3, -65);
            this.Volume_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Volume_btn.Name = "Volume_btn";
            this.Volume_btn.Size = new System.Drawing.Size(46, 126);
            this.Volume_btn.TabIndex = 13;
            this.Volume_btn.TabStop = false;
            this.Volume_btn.Text = " 🔊";
            this.Volume_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Volume_btn.UseVisualStyleBackColor = false;
            this.Volume_btn.Click += new System.EventHandler(this.Volume_btn_Click);
            this.Volume_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullscreenBtn.BackgroundImage")));
            this.FullscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullscreenBtn.FlatAppearance.BorderSize = 0;
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullscreenBtn.Location = new System.Drawing.Point(969, 17);
            this.FullscreenBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(30, 31);
            this.FullscreenBtn.TabIndex = 5;
            this.FullscreenBtn.TabStop = false;
            this.FullscreenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FullscreenBtn.UseVisualStyleBackColor = true;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            this.FullscreenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 700;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Main_cms
            // 
            this.Main_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Main_cms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMedia_option_cms,
            this.NewPlaylist_option_cms,
            this.audioPlayerModeToolStripMenuItem,
            this.About_option_cms,
            this.Exit_option_cms});
            this.Main_cms.Name = "Main_cms";
            this.Main_cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Main_cms.Size = new System.Drawing.Size(238, 164);
            // 
            // OpenMedia_option_cms
            // 
            this.OpenMedia_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.OpenMedia_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenMedia_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OpenMedia_option_cms.ImageTransparentColor = System.Drawing.Color.Silver;
            this.OpenMedia_option_cms.Name = "OpenMedia_option_cms";
            this.OpenMedia_option_cms.Size = new System.Drawing.Size(237, 32);
            this.OpenMedia_option_cms.Text = "Open Media";
            this.OpenMedia_option_cms.Click += new System.EventHandler(this.OpenMedia_option_cms_Click);
            // 
            // NewPlaylist_option_cms
            // 
            this.NewPlaylist_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.NewPlaylist_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewPlaylist_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewPlaylist_option_cms.Name = "NewPlaylist_option_cms";
            this.NewPlaylist_option_cms.Size = new System.Drawing.Size(237, 32);
            this.NewPlaylist_option_cms.Text = "Playlist Menu";
            this.NewPlaylist_option_cms.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // audioPlayerModeToolStripMenuItem
            // 
            this.audioPlayerModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioPlayerModeToolStripMenuItem.Name = "audioPlayerModeToolStripMenuItem";
            this.audioPlayerModeToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.audioPlayerModeToolStripMenuItem.Text = "Audio/Video Mode";
            this.audioPlayerModeToolStripMenuItem.Click += new System.EventHandler(this.audioPlayerModeToolStripMenuItem_Click);
            // 
            // About_option_cms
            // 
            this.About_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.About_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.About_option_cms.Name = "About_option_cms";
            this.About_option_cms.Size = new System.Drawing.Size(237, 32);
            this.About_option_cms.Text = "About";
            this.About_option_cms.Click += new System.EventHandler(this.About_option_cms_Click);
            // 
            // Exit_option_cms
            // 
            this.Exit_option_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Exit_option_cms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Exit_option_cms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit_option_cms.Name = "Exit_option_cms";
            this.Exit_option_cms.Size = new System.Drawing.Size(237, 32);
            this.Exit_option_cms.Text = "Exit";
            this.Exit_option_cms.Click += new System.EventHandler(this.Exit_option_cms_Click);
            // 
            // Video_panel
            // 
            this.Video_panel.AllowDrop = true;
            this.Video_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_panel.BackColor = System.Drawing.Color.Silver;
            this.Video_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Video_panel.BackgroundImage")));
            this.Video_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Video_panel.Controls.Add(this.Playlist_FlowPanel);
            this.Video_panel.Controls.Add(this.TrackBar);
            this.Video_panel.Controls.Add(this.Player_wmp);
            this.Video_panel.Location = new System.Drawing.Point(3, 8);
            this.Video_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Video_panel.Name = "Video_panel";
            this.Video_panel.Size = new System.Drawing.Size(997, 532);
            this.Video_panel.TabIndex = 2;
            this.Video_panel.Click += new System.EventHandler(this.Video_panel_Click);
            this.Video_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragDrop);
            this.Video_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Video_panel_DragEnter);
            this.Video_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Video_panel_Paint);
            this.Video_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            // 
            // Playlist_FlowPanel
            // 
            this.Playlist_FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist_FlowPanel.BackColor = System.Drawing.Color.Gray;
            this.Playlist_FlowPanel.Controls.Add(this.NewPlayLBtn);
            this.Playlist_FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Playlist_FlowPanel.Location = new System.Drawing.Point(24, 10);
            this.Playlist_FlowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Playlist_FlowPanel.Name = "Playlist_FlowPanel";
            this.Playlist_FlowPanel.Size = new System.Drawing.Size(320, 466);
            this.Playlist_FlowPanel.TabIndex = 10;
            this.Playlist_FlowPanel.Visible = false;
            // 
            // NewPlayLBtn
            // 
            this.NewPlayLBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewPlayLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.NewPlayLBtn.FlatAppearance.BorderSize = 0;
            this.NewPlayLBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.NewPlayLBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.NewPlayLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlayLBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlayLBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPlayLBtn.Location = new System.Drawing.Point(0, 0);
            this.NewPlayLBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NewPlayLBtn.Name = "NewPlayLBtn";
            this.NewPlayLBtn.Size = new System.Drawing.Size(352, 75);
            this.NewPlayLBtn.TabIndex = 13;
            this.NewPlayLBtn.TabStop = false;
            this.NewPlayLBtn.Text = "New Playlist";
            this.NewPlayLBtn.UseVisualStyleBackColor = false;
            this.NewPlayLBtn.Click += new System.EventHandler(this.NewPlayLBtn_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.TrackBar.BarInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.TrackBar.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.TrackBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TrackBar.ElapsedInnerColor = System.Drawing.Color.Silver;
            this.TrackBar.ElapsedPenColorBottom = System.Drawing.Color.DimGray;
            this.TrackBar.ElapsedPenColorTop = System.Drawing.Color.Silver;
            this.TrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.TrackBar.ForeColor = System.Drawing.Color.White;
            this.TrackBar.LargeChange = ((uint)(5u));
            this.TrackBar.Location = new System.Drawing.Point(0, 490);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.ScaleDivisions = 10;
            this.TrackBar.ScaleSubDivisions = 5;
            this.TrackBar.ShowDivisionsText = true;
            this.TrackBar.ShowSmallScale = false;
            this.TrackBar.Size = new System.Drawing.Size(997, 42);
            this.TrackBar.SmallChange = ((uint)(1u));
            this.TrackBar.TabIndex = 8;
            this.TrackBar.Text = "colorSlider1";
            this.TrackBar.ThumbInnerColor = System.Drawing.Color.DimGray;
            this.TrackBar.ThumbOuterColor = System.Drawing.Color.LightCyan;
            this.TrackBar.ThumbPenColor = System.Drawing.Color.Black;
            this.TrackBar.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.TrackBar.ThumbSize = new System.Drawing.Size(16, 16);
            this.TrackBar.TickAdd = 0F;
            this.TrackBar.TickColor = System.Drawing.Color.Maroon;
            this.TrackBar.TickDivide = 0F;
            this.TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar.Value = 0;
            this.TrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar_Scroll);
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // Player_wmp
            // 
            this.Player_wmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_wmp.Enabled = true;
            this.Player_wmp.Location = new System.Drawing.Point(6, 4);
            this.Player_wmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player_wmp.Name = "Player_wmp";
            this.Player_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_wmp.OcxState")));
            this.Player_wmp.Size = new System.Drawing.Size(665, 350);
            this.Player_wmp.TabIndex = 9;
            this.Player_wmp.Visible = false;
            this.Player_wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_wmp_PlayStateChange);
            this.Player_wmp.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Player_wmp_MediaChange);
            this.Player_wmp.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Player_wmp_ClickEvent);
            this.Player_wmp.Enter += new System.EventHandler(this.Player_wmp_Enter);
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.radioButton4);
            this.menu.Controls.Add(this.radioButton3);
            this.menu.Controls.Add(this.radioButton1);
            this.menu.Controls.Add(this.panel1);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(257, 650);
            this.menu.TabIndex = 4;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(21, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add Music";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Music";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(21, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(21, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton4.Location = new System.Drawing.Point(21, 223);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 31);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Library";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton3.Location = new System.Drawing.Point(21, 260);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 31);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Playlist";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.Location = new System.Drawing.Point(21, 186);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(196, 31);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Now Playing ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 118);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.PinIcon_btn);
            this.TitleBar_panel.Controls.Add(this.Logo_pbox);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.Min_Button);
            this.TitleBar_panel.Controls.Add(this.Max_Button);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Location = new System.Drawing.Point(257, 0);
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(1013, 48);
            this.TitleBar_panel.TabIndex = 5;
            this.TitleBar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_panel_Paint);
            this.TitleBar_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainCms_MouseClick);
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(603, 8);
            this.foCUS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(27, 31);
            this.foCUS.TabIndex = 9;
            this.foCUS.Paint += new System.Windows.Forms.PaintEventHandler(this.foCUS_Paint);
            this.foCUS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // PinIcon_btn
            // 
            this.PinIcon_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PinIcon_btn.FlatAppearance.BorderSize = 0;
            this.PinIcon_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PinIcon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinIcon_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinIcon_btn.ForeColor = System.Drawing.Color.Beige;
            this.PinIcon_btn.Location = new System.Drawing.Point(735, 0);
            this.PinIcon_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PinIcon_btn.Name = "PinIcon_btn";
            this.PinIcon_btn.Size = new System.Drawing.Size(68, 45);
            this.PinIcon_btn.TabIndex = 7;
            this.PinIcon_btn.Text = "📌";
            this.PinIcon_btn.UseVisualStyleBackColor = true;
            // 
            // Logo_pbox
            // 
            this.Logo_pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_pbox.Location = new System.Drawing.Point(-3, -6);
            this.Logo_pbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo_pbox.Name = "Logo_pbox";
            this.Logo_pbox.Size = new System.Drawing.Size(68, 56);
            this.Logo_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_pbox.TabIndex = 0;
            this.Logo_pbox.TabStop = false;
            this.Logo_pbox.Click += new System.EventHandler(this.MainControl_panel_Click);
            this.Logo_pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(73, 5);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(265, 33);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Wave Music Player";
            this.EliteMediaPlayer_label.Click += new System.EventHandler(this.EliteMediaPlayer_label_Click_1);
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Min_Button
            // 
            this.Min_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min_Button.FlatAppearance.BorderSize = 0;
            this.Min_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min_Button.Location = new System.Drawing.Point(805, 2);
            this.Min_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Min_Button.Name = "Min_Button";
            this.Min_Button.Size = new System.Drawing.Size(68, 48);
            this.Min_Button.TabIndex = 4;
            this.Min_Button.TabStop = false;
            this.Min_Button.Text = "_";
            this.Min_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min_Button.UseVisualStyleBackColor = true;
            this.Min_Button.Click += new System.EventHandler(this.Min_Button_Click_1);
            this.Min_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Min_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Min_Button_Move);
            this.Min_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Max_Button
            // 
            this.Max_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Button.FlatAppearance.BorderSize = 0;
            this.Max_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Max_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max_Button.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Max_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max_Button.Location = new System.Drawing.Point(873, 2);
            this.Max_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Max_Button.Name = "Max_Button";
            this.Max_Button.Size = new System.Drawing.Size(68, 46);
            this.Max_Button.TabIndex = 3;
            this.Max_Button.TabStop = false;
            this.Max_Button.Text = "1";
            this.Max_Button.UseVisualStyleBackColor = true;
            this.Max_Button.Click += new System.EventHandler(this.Max_Button_Click_1);
            this.Max_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Max_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Max_Button_MouseMove);
            this.Max_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(943, 2);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(68, 46);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.TabStop = false;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click_1);
            this.Cross_Button.MouseLeave += new System.EventHandler(this.CMM_Buttons_Leave);
            this.Cross_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cross_Button_MouseMove);
            this.Cross_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FoucsToMain_trackBar_MouseUp);
            // 
            // childpanel
            // 
            this.childpanel.BackColor = System.Drawing.Color.Gray;
            this.childpanel.Controls.Add(this.panelWave);
            this.childpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childpanel.Location = new System.Drawing.Point(0, 0);
            this.childpanel.Name = "childpanel";
            this.childpanel.Size = new System.Drawing.Size(1270, 650);
            this.childpanel.TabIndex = 2;
            // 
            // panelWave
            // 
            this.panelWave.Controls.Add(this.BelowPanel);
            this.panelWave.Controls.Add(this.Video_panel);
            this.panelWave.Location = new System.Drawing.Point(257, 42);
            this.panelWave.Name = "panelWave";
            this.panelWave.Size = new System.Drawing.Size(1001, 608);
            this.panelWave.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 650);
            this.Controls.Add(this.TitleBar_panel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.childpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Appliction_KeyUp);
            this.MainControl_panel.ResumeLayout(false);
            this.BelowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Volume_trackBar)).EndInit();
            this.Main_cms.ResumeLayout(false);
            this.Video_panel.ResumeLayout(false);
            this.Playlist_FlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player_wmp)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pbox)).EndInit();
            this.childpanel.ResumeLayout(false);
            this.panelWave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Panel MainControl_panel;
        private System.Windows.Forms.Button PlayPause_btn;
        private System.Windows.Forms.Panel BelowPanel;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.Button Replay_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Volume_btn;
        private System.Windows.Forms.TrackBar Volume_trackBar;
        private ColorSlider.ColorSlider TrackBar;
        private System.Windows.Forms.Panel Video_panel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ContextMenuStrip Main_cms;
        private System.Windows.Forms.ToolStripMenuItem OpenMedia_option_cms;
        private System.Windows.Forms.ToolStripMenuItem NewPlaylist_option_cms;
        private System.Windows.Forms.ToolStripMenuItem About_option_cms;
        private System.Windows.Forms.ToolStripMenuItem Exit_option_cms;
        private AxWMPLib.AxWindowsMediaPlayer Player_wmp;
        private System.Windows.Forms.FlowLayoutPanel Playlist_FlowPanel;
        private System.Windows.Forms.ToolStripMenuItem audioPlayerModeToolStripMenuItem;
        private System.Windows.Forms.Button NewPlayLBtn;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel childpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Button PinIcon_btn;
        private System.Windows.Forms.PictureBox Logo_pbox;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Min_Button;
        private System.Windows.Forms.Button Max_Button;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.Panel panelWave;
    }
}