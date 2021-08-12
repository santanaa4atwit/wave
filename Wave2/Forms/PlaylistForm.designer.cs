namespace Wave2.Forms
{
    partial class PlaylistForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.SavePlaylist_btn = new System.Windows.Forms.Button();
            this.LoadPlaylist_btn = new System.Windows.Forms.Button();
            this.NewPlaylist_btn = new System.Windows.Forms.Button();
            this.AddFiles_btn = new System.Windows.Forms.Button();
            this.AddFolder_btn = new System.Windows.Forms.Button();
            this.Play_lebel = new System.Windows.Forms.Button();
            this.Playlist_datagrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AudioNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletion_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete_cmsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Min_Button = new System.Windows.Forms.Button();
            this.Max_Button = new System.Windows.Forms.Button();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.Playlist_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).BeginInit();
            this.Deletion_cms.SuspendLayout();
            this.TitleBar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(16, 10);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(295, 45);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Playlist Menu";
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // SavePlaylist_btn
            // 
            this.SavePlaylist_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePlaylist_btn.BackColor = System.Drawing.Color.Black;
            this.SavePlaylist_btn.FlatAppearance.BorderSize = 0;
            this.SavePlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SavePlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SavePlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePlaylist_btn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SavePlaylist_btn.Location = new System.Drawing.Point(345, 602);
            this.SavePlaylist_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SavePlaylist_btn.Name = "SavePlaylist_btn";
            this.SavePlaylist_btn.Size = new System.Drawing.Size(329, 86);
            this.SavePlaylist_btn.TabIndex = 9;
            this.SavePlaylist_btn.Text = "Save a Playlist";
            this.SavePlaylist_btn.UseVisualStyleBackColor = false;
            this.SavePlaylist_btn.Click += new System.EventHandler(this.SavePlaylist_btn_Click_1);
            // 
            // LoadPlaylist_btn
            // 
            this.LoadPlaylist_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadPlaylist_btn.BackColor = System.Drawing.Color.Black;
            this.LoadPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.LoadPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LoadPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPlaylist_btn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadPlaylist_btn.Location = new System.Drawing.Point(17, 602);
            this.LoadPlaylist_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoadPlaylist_btn.Name = "LoadPlaylist_btn";
            this.LoadPlaylist_btn.Size = new System.Drawing.Size(317, 86);
            this.LoadPlaylist_btn.TabIndex = 8;
            this.LoadPlaylist_btn.Text = "Load a Playlist";
            this.LoadPlaylist_btn.UseVisualStyleBackColor = false;
            this.LoadPlaylist_btn.Click += new System.EventHandler(this.LoadPlaylist_btn_Click_1);
            // 
            // NewPlaylist_btn
            // 
            this.NewPlaylist_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewPlaylist_btn.BackColor = System.Drawing.Color.Black;
            this.NewPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.NewPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NewPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlaylist_btn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NewPlaylist_btn.Location = new System.Drawing.Point(685, 602);
            this.NewPlaylist_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NewPlaylist_btn.Name = "NewPlaylist_btn";
            this.NewPlaylist_btn.Size = new System.Drawing.Size(319, 86);
            this.NewPlaylist_btn.TabIndex = 7;
            this.NewPlaylist_btn.Text = "Create New Playlist";
            this.NewPlaylist_btn.UseVisualStyleBackColor = false;
            this.NewPlaylist_btn.Click += new System.EventHandler(this.NewPlaylist_btn_Click_1);
            // 
            // AddFiles_btn
            // 
            this.AddFiles_btn.BackColor = System.Drawing.Color.Black;
            this.AddFiles_btn.FlatAppearance.BorderSize = 0;
            this.AddFiles_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFiles_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFiles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFiles_btn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiles_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFiles_btn.Location = new System.Drawing.Point(25, 72);
            this.AddFiles_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddFiles_btn.Name = "AddFiles_btn";
            this.AddFiles_btn.Size = new System.Drawing.Size(232, 69);
            this.AddFiles_btn.TabIndex = 8;
            this.AddFiles_btn.Text = "Add Songs";
            this.AddFiles_btn.UseVisualStyleBackColor = false;
            this.AddFiles_btn.Click += new System.EventHandler(this.AddFiles_btn_Click_1);
            // 
            // AddFolder_btn
            // 
            this.AddFolder_btn.BackColor = System.Drawing.Color.Black;
            this.AddFolder_btn.FlatAppearance.BorderSize = 0;
            this.AddFolder_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFolder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFolder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolder_btn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFolder_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFolder_btn.Location = new System.Drawing.Point(279, 72);
            this.AddFolder_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddFolder_btn.Name = "AddFolder_btn";
            this.AddFolder_btn.Size = new System.Drawing.Size(232, 69);
            this.AddFolder_btn.TabIndex = 9;
            this.AddFolder_btn.Text = "Add Folder";
            this.AddFolder_btn.UseVisualStyleBackColor = false;
            this.AddFolder_btn.Click += new System.EventHandler(this.AddFolder_btn_Click_1);
            // 
            // Play_lebel
            // 
            this.Play_lebel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Play_lebel.AutoSize = true;
            this.Play_lebel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Play_lebel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Play_lebel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatAppearance.BorderSize = 0;
            this.Play_lebel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_lebel.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_lebel.ForeColor = System.Drawing.Color.Green;
            this.Play_lebel.Location = new System.Drawing.Point(1173, 705);
            this.Play_lebel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Play_lebel.Name = "Play_lebel";
            this.Play_lebel.Size = new System.Drawing.Size(263, 82);
            this.Play_lebel.TabIndex = 12;
            this.Play_lebel.Text = "Play!";
            this.Play_lebel.UseVisualStyleBackColor = false;
            this.Play_lebel.Click += new System.EventHandler(this.Play_lebel_Click_1);
            this.Play_lebel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_lebel_MouseDown);
            this.Play_lebel.MouseLeave += new System.EventHandler(this.Play_lebel_MouseLeave);
            this.Play_lebel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Play_lebel_MouseMove);
            // 
            // Playlist_datagrid
            // 
            this.Playlist_datagrid.AllowDrop = true;
            this.Playlist_datagrid.AllowUserToAddRows = false;
            this.Playlist_datagrid.AllowUserToDeleteRows = false;
            this.Playlist_datagrid.AllowUserToResizeColumns = false;
            this.Playlist_datagrid.AllowUserToResizeRows = false;
            this.Playlist_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Playlist_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Playlist_datagrid.ColumnHeadersHeight = 34;
            this.Playlist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Playlist_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AudioNames});
            this.Playlist_datagrid.Location = new System.Drawing.Point(25, 172);
            this.Playlist_datagrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Playlist_datagrid.Name = "Playlist_datagrid";
            this.Playlist_datagrid.ReadOnly = true;
            this.Playlist_datagrid.RowHeadersWidth = 62;
            this.Playlist_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Playlist_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Playlist_datagrid.Size = new System.Drawing.Size(1015, 396);
            this.Playlist_datagrid.TabIndex = 13;
            this.Playlist_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Playlist_datagrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "SNo.";
            this.ID.MinimumWidth = 70;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 70;
            // 
            // AudioNames
            // 
            this.AudioNames.HeaderText = "Name";
            this.AudioNames.MinimumWidth = 520;
            this.AudioNames.Name = "AudioNames";
            this.AudioNames.ReadOnly = true;
            this.AudioNames.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AudioNames.Width = 520;
            // 
            // Deletion_cms
            // 
            this.Deletion_cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.Deletion_cms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Deletion_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_cmsBtn});
            this.Deletion_cms.Name = "Main_cms";
            this.Deletion_cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Deletion_cms.Size = new System.Drawing.Size(177, 42);
            // 
            // delete_cmsBtn
            // 
            this.delete_cmsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.delete_cmsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delete_cmsBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.delete_cmsBtn.ImageTransparentColor = System.Drawing.Color.Silver;
            this.delete_cmsBtn.Name = "delete_cmsBtn";
            this.delete_cmsBtn.Size = new System.Drawing.Size(176, 38);
            this.delete_cmsBtn.Text = "Remove";
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.label2);
            this.TitleBar_panel.Controls.Add(this.Min_Button);
            this.TitleBar_panel.Controls.Add(this.Max_Button);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(1449, 60);
            this.TitleBar_panel.TabIndex = 15;
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove_2);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(617, 12);
            this.foCUS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(36, 39);
            this.foCUS.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(97, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 44);
            this.label2.TabIndex = 6;
            // 
            // Min_Button
            // 
            this.Min_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min_Button.FlatAppearance.BorderSize = 0;
            this.Min_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min_Button.Location = new System.Drawing.Point(1172, 2);
            this.Min_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Min_Button.Name = "Min_Button";
            this.Min_Button.Size = new System.Drawing.Size(91, 60);
            this.Min_Button.TabIndex = 4;
            this.Min_Button.TabStop = false;
            this.Min_Button.Text = "_";
            this.Min_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min_Button.UseVisualStyleBackColor = true;
            this.Min_Button.Click += new System.EventHandler(this.Min_Button_Click);
            // 
            // Max_Button
            // 
            this.Max_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Button.FlatAppearance.BorderSize = 0;
            this.Max_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Max_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max_Button.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Max_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max_Button.Location = new System.Drawing.Point(1263, 2);
            this.Max_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Max_Button.Name = "Max_Button";
            this.Max_Button.Size = new System.Drawing.Size(91, 58);
            this.Max_Button.TabIndex = 3;
            this.Max_Button.TabStop = false;
            this.Max_Button.Text = "1";
            this.Max_Button.UseVisualStyleBackColor = true;
            this.Max_Button.Click += new System.EventHandler(this.Max_Button_Click_1);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(1356, 2);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(91, 58);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.TabStop = false;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            // 
            // Playlist_FlowPanel
            // 
            this.Playlist_FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Playlist_FlowPanel.BackColor = System.Drawing.Color.Gray;
            this.Playlist_FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Playlist_FlowPanel.Location = new System.Drawing.Point(1051, 96);
            this.Playlist_FlowPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Playlist_FlowPanel.Name = "Playlist_FlowPanel";
            this.Playlist_FlowPanel.Size = new System.Drawing.Size(360, 509);
            this.Playlist_FlowPanel.TabIndex = 16;
            this.Playlist_FlowPanel.Visible = false;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1449, 794);
            this.Controls.Add(this.Playlist_FlowPanel);
            this.Controls.Add(this.LoadPlaylist_btn);
            this.Controls.Add(this.NewPlaylist_btn);
            this.Controls.Add(this.SavePlaylist_btn);
            this.Controls.Add(this.TitleBar_panel);
            this.Controls.Add(this.Playlist_datagrid);
            this.Controls.Add(this.Play_lebel);
            this.Controls.Add(this.AddFolder_btn);
            this.Controls.Add(this.AddFiles_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).EndInit();
            this.Deletion_cms.ResumeLayout(false);
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button SavePlaylist_btn;
        private System.Windows.Forms.Button LoadPlaylist_btn;
        private System.Windows.Forms.Button NewPlaylist_btn;
        private System.Windows.Forms.Button AddFiles_btn;
        private System.Windows.Forms.Button AddFolder_btn;
        private System.Windows.Forms.Button Play_lebel;
        public System.Windows.Forms.DataGridView Playlist_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AudioNames;
        private System.Windows.Forms.ContextMenuStrip Deletion_cms;
        private System.Windows.Forms.ToolStripMenuItem delete_cmsBtn;
        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Min_Button;
        private System.Windows.Forms.Button Max_Button;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.FlowLayoutPanel Playlist_FlowPanel;
    }
}