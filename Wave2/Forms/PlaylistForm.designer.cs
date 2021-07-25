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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.SavePlaylist_btn = new System.Windows.Forms.Button();
            this.LoadPlaylist_btn = new System.Windows.Forms.Button();
            this.NewPlaylist_btn = new System.Windows.Forms.Button();
            this.AddFiles_btn = new System.Windows.Forms.Button();
            this.AddFolder_btn = new System.Windows.Forms.Button();
            this.Repeat_check = new System.Windows.Forms.CheckBox();
            this.Shuffle_check = new System.Windows.Forms.CheckBox();
            this.Play_lebel = new System.Windows.Forms.Button();
            this.Playlist_datagrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AudioNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletion_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete_cmsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleBar_panel.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).BeginInit();
            this.Deletion_cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar_panel
            // 
            this.TitleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TitleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar_panel.Controls.Add(this.foCUS);
            this.TitleBar_panel.Controls.Add(this.EliteMediaPlayer_label);
            this.TitleBar_panel.Controls.Add(this.Cross_Button);
            this.TitleBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(1052, 51);
            this.TitleBar_panel.TabIndex = 3;
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(366, 9);
            this.foCUS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(27, 31);
            this.foCUS.TabIndex = 9;
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(9, 6);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(181, 36);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Playlist Menu";
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(981, 2);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(68, 46);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click_1);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.Menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Menu_panel.Controls.Add(this.SavePlaylist_btn);
            this.Menu_panel.Controls.Add(this.LoadPlaylist_btn);
            this.Menu_panel.Controls.Add(this.NewPlaylist_btn);
            this.Menu_panel.Location = new System.Drawing.Point(50, 75);
            this.Menu_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(784, 67);
            this.Menu_panel.TabIndex = 7;
            // 
            // SavePlaylist_btn
            // 
            this.SavePlaylist_btn.BackColor = System.Drawing.Color.Transparent;
            this.SavePlaylist_btn.FlatAppearance.BorderSize = 0;
            this.SavePlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SavePlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SavePlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SavePlaylist_btn.Location = new System.Drawing.Point(519, -2);
            this.SavePlaylist_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePlaylist_btn.Name = "SavePlaylist_btn";
            this.SavePlaylist_btn.Size = new System.Drawing.Size(261, 69);
            this.SavePlaylist_btn.TabIndex = 9;
            this.SavePlaylist_btn.Text = "Save Playlist";
            this.SavePlaylist_btn.UseVisualStyleBackColor = false;
            this.SavePlaylist_btn.Click += new System.EventHandler(this.SavePlaylist_btn_Click_1);
            // 
            // LoadPlaylist_btn
            // 
            this.LoadPlaylist_btn.BackColor = System.Drawing.Color.Transparent;
            this.LoadPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.LoadPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LoadPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadPlaylist_btn.Location = new System.Drawing.Point(258, -2);
            this.LoadPlaylist_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadPlaylist_btn.Name = "LoadPlaylist_btn";
            this.LoadPlaylist_btn.Size = new System.Drawing.Size(261, 69);
            this.LoadPlaylist_btn.TabIndex = 8;
            this.LoadPlaylist_btn.Text = "Load Playlist";
            this.LoadPlaylist_btn.UseVisualStyleBackColor = false;
            this.LoadPlaylist_btn.Click += new System.EventHandler(this.LoadPlaylist_btn_Click_1);
            // 
            // NewPlaylist_btn
            // 
            this.NewPlaylist_btn.BackColor = System.Drawing.Color.Transparent;
            this.NewPlaylist_btn.FlatAppearance.BorderSize = 0;
            this.NewPlaylist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPlaylist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NewPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPlaylist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlaylist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NewPlaylist_btn.Location = new System.Drawing.Point(20, -2);
            this.NewPlaylist_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPlaylist_btn.Name = "NewPlaylist_btn";
            this.NewPlaylist_btn.Size = new System.Drawing.Size(238, 69);
            this.NewPlaylist_btn.TabIndex = 7;
            this.NewPlaylist_btn.Text = "New Playlist";
            this.NewPlaylist_btn.UseVisualStyleBackColor = false;
            this.NewPlaylist_btn.Click += new System.EventHandler(this.NewPlaylist_btn_Click_1);
            // 
            // AddFiles_btn
            // 
            this.AddFiles_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddFiles_btn.FlatAppearance.BorderSize = 0;
            this.AddFiles_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFiles_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFiles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFiles_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiles_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFiles_btn.Location = new System.Drawing.Point(50, 473);
            this.AddFiles_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddFiles_btn.Name = "AddFiles_btn";
            this.AddFiles_btn.Size = new System.Drawing.Size(174, 55);
            this.AddFiles_btn.TabIndex = 8;
            this.AddFiles_btn.Text = "Add Files";
            this.AddFiles_btn.UseVisualStyleBackColor = false;
            this.AddFiles_btn.Click += new System.EventHandler(this.AddFiles_btn_Click_1);
            // 
            // AddFolder_btn
            // 
            this.AddFolder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddFolder_btn.FlatAppearance.BorderSize = 0;
            this.AddFolder_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFolder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddFolder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFolder_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddFolder_btn.Location = new System.Drawing.Point(232, 473);
            this.AddFolder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddFolder_btn.Name = "AddFolder_btn";
            this.AddFolder_btn.Size = new System.Drawing.Size(174, 55);
            this.AddFolder_btn.TabIndex = 9;
            this.AddFolder_btn.Text = "Add Folder";
            this.AddFolder_btn.UseVisualStyleBackColor = false;
            this.AddFolder_btn.Click += new System.EventHandler(this.AddFolder_btn_Click_1);
            // 
            // Repeat_check
            // 
            this.Repeat_check.AutoSize = true;
            this.Repeat_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_check.Location = new System.Drawing.Point(437, 473);
            this.Repeat_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Repeat_check.Name = "Repeat_check";
            this.Repeat_check.Size = new System.Drawing.Size(134, 37);
            this.Repeat_check.TabIndex = 10;
            this.Repeat_check.Text = "Repeat";
            this.Repeat_check.UseVisualStyleBackColor = true;
            this.Repeat_check.CheckedChanged += new System.EventHandler(this.Repeat_check_CheckedChanged);
            // 
            // Shuffle_check
            // 
            this.Shuffle_check.AutoSize = true;
            this.Shuffle_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shuffle_check.Location = new System.Drawing.Point(579, 473);
            this.Shuffle_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Shuffle_check.Name = "Shuffle_check";
            this.Shuffle_check.Size = new System.Drawing.Size(131, 37);
            this.Shuffle_check.TabIndex = 11;
            this.Shuffle_check.Text = "Shuffle";
            this.Shuffle_check.UseVisualStyleBackColor = true;
            // 
            // Play_lebel
            // 
            this.Play_lebel.AutoSize = true;
            this.Play_lebel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Play_lebel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatAppearance.BorderSize = 0;
            this.Play_lebel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.Play_lebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Play_lebel.ForeColor = System.Drawing.Color.Crimson;
            this.Play_lebel.Location = new System.Drawing.Point(732, 434);
            this.Play_lebel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Play_lebel.Name = "Play_lebel";
            this.Play_lebel.Size = new System.Drawing.Size(147, 85);
            this.Play_lebel.TabIndex = 12;
            this.Play_lebel.Text = "Play";
            this.Play_lebel.UseVisualStyleBackColor = true;
            this.Play_lebel.Click += new System.EventHandler(this.Play_lebel_Click_1);
            // 
            // Playlist_datagrid
            // 
            this.Playlist_datagrid.AllowDrop = true;
            this.Playlist_datagrid.AllowUserToAddRows = false;
            this.Playlist_datagrid.AllowUserToDeleteRows = false;
            this.Playlist_datagrid.AllowUserToResizeColumns = false;
            this.Playlist_datagrid.AllowUserToResizeRows = false;
            this.Playlist_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Playlist_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Playlist_datagrid.ColumnHeadersHeight = 34;
            this.Playlist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Playlist_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AudioNames});
            this.Playlist_datagrid.Location = new System.Drawing.Point(85, 152);
            this.Playlist_datagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Playlist_datagrid.Name = "Playlist_datagrid";
            this.Playlist_datagrid.ReadOnly = true;
            this.Playlist_datagrid.RowHeadersWidth = 62;
            this.Playlist_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Playlist_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Playlist_datagrid.Size = new System.Drawing.Size(726, 296);
            this.Playlist_datagrid.TabIndex = 13;
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
            this.Deletion_cms.Size = new System.Drawing.Size(149, 36);
            // 
            // delete_cmsBtn
            // 
            this.delete_cmsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.delete_cmsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delete_cmsBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.delete_cmsBtn.ImageTransparentColor = System.Drawing.Color.Silver;
            this.delete_cmsBtn.Name = "delete_cmsBtn";
            this.delete_cmsBtn.Size = new System.Drawing.Size(148, 32);
            this.delete_cmsBtn.Text = "Remove";
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 614);
            this.Controls.Add(this.Playlist_datagrid);
            this.Controls.Add(this.Play_lebel);
            this.Controls.Add(this.Shuffle_check);
            this.Controls.Add(this.Repeat_check);
            this.Controls.Add(this.AddFolder_btn);
            this.Controls.Add(this.AddFiles_btn);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.TitleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            this.Menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_datagrid)).EndInit();
            this.Deletion_cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Button SavePlaylist_btn;
        private System.Windows.Forms.Button LoadPlaylist_btn;
        private System.Windows.Forms.Button NewPlaylist_btn;
        private System.Windows.Forms.Button AddFiles_btn;
        private System.Windows.Forms.Button AddFolder_btn;
        private System.Windows.Forms.CheckBox Repeat_check;
        private System.Windows.Forms.CheckBox Shuffle_check;
        private System.Windows.Forms.Button Play_lebel;
        private System.Windows.Forms.DataGridView Playlist_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AudioNames;
        private System.Windows.Forms.ContextMenuStrip Deletion_cms;
        private System.Windows.Forms.ToolStripMenuItem delete_cmsBtn;
    }
}