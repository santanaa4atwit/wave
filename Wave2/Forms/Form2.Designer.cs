﻿namespace Wave2.Forms
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.TitleBar_panel.Size = new System.Drawing.Size(1067, 63);
            this.TitleBar_panel.TabIndex = 4;
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
            this.EliteMediaPlayer_label.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliteMediaPlayer_label.ForeColor = System.Drawing.Color.White;
            this.EliteMediaPlayer_label.Location = new System.Drawing.Point(12, 8);
            this.EliteMediaPlayer_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EliteMediaPlayer_label.Name = "EliteMediaPlayer_label";
            this.EliteMediaPlayer_label.Size = new System.Drawing.Size(179, 45);
            this.EliteMediaPlayer_label.TabIndex = 6;
            this.EliteMediaPlayer_label.Text = "Library ";
            this.EliteMediaPlayer_label.Click += new System.EventHandler(this.EliteMediaPlayer_label_Click);
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
            this.Cross_Button.Location = new System.Drawing.Point(973, 2);
            this.Cross_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Cross_Button.Name = "Cross_Button";
            this.Cross_Button.Size = new System.Drawing.Size(91, 58);
            this.Cross_Button.TabIndex = 2;
            this.Cross_Button.Text = "X";
            this.Cross_Button.UseVisualStyleBackColor = true;
            this.Cross_Button.Click += new System.EventHandler(this.Cross_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(38, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(992, 337);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 101);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TitleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TitleBar_panel.ResumeLayout(false);
            this.TitleBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_panel;
        private System.Windows.Forms.Panel foCUS;
        private System.Windows.Forms.Label EliteMediaPlayer_label;
        private System.Windows.Forms.Button Cross_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}