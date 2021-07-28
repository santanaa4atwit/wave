namespace Wave2.Forms
{
    partial class AddMusic
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
            this.TitleBar_panel = new System.Windows.Forms.Panel();
            this.foCUS = new System.Windows.Forms.Panel();
            this.EliteMediaPlayer_label = new System.Windows.Forms.Label();
            this.Cross_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddFiles_btn = new System.Windows.Forms.Button();
            this.AddFolder_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TitleBar_panel.SuspendLayout();
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
            this.TitleBar_panel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TitleBar_panel.Name = "TitleBar_panel";
            this.TitleBar_panel.Size = new System.Drawing.Size(1024, 63);
            this.TitleBar_panel.TabIndex = 4;
            this.TitleBar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_panel_Paint);
            this.TitleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // foCUS
            // 
            this.foCUS.Location = new System.Drawing.Point(488, 11);
            this.foCUS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.foCUS.Name = "foCUS";
            this.foCUS.Size = new System.Drawing.Size(36, 39);
            this.foCUS.TabIndex = 9;
            // 
            // EliteMediaPlayer_label
            // 
            this.EliteMediaPlayer_label.AutoSize = true;
            this.EliteMediaPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(12, 8);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(190, 46);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Add Music";
            this.EliteMediaPlayer_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_panel_MouseMove);
            // 
            // Cross_Button
            // 
            this.Cross_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cross_Button.FlatAppearance.BorderSize = 0;
            this.Cross_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Cross_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cross_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cross_Button.Location = new System.Drawing.Point(929, 2);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(91, 58);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1020, 505);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.AddFiles_btn.Location = new System.Drawing.Point(180, 120);
            this.AddFiles_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddFiles_btn.Name = "AddFiles_btn";
            this.AddFiles_btn.Size = new System.Drawing.Size(644, 84);
            this.AddFiles_btn.TabIndex = 9;
            this.AddFiles_btn.Text = "Add Files";
            this.AddFiles_btn.UseVisualStyleBackColor = false;
            this.AddFiles_btn.Click += new System.EventHandler(this.AddFiles_btn_Click);
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
            this.AddFolder_btn.Location = new System.Drawing.Point(180, 244);
            this.AddFolder_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddFolder_btn.Name = "AddFolder_btn";
            this.AddFolder_btn.Size = new System.Drawing.Size(644, 85);
            this.AddFolder_btn.TabIndex = 10;
            this.AddFolder_btn.Text = "Add Folder";
            this.AddFolder_btn.UseVisualStyleBackColor = false;
            this.AddFolder_btn.Click += new System.EventHandler(this.AddFolder_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(408, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add to Library";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(700, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 69);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddFolder_btn);
            this.Controls.Add(this.AddFiles_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMusic";
            this.Text = "AboutForm";
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddFiles_btn;
        private System.Windows.Forms.Button AddFolder_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}