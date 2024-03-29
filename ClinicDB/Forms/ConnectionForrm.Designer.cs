﻿
namespace ClinicDB.Forms
{
    partial class ConnectionForrm
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
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileName = new RJCodeAdvance.RJControls.RJTextBox();
            this.sourceText = new RJCodeAdvance.RJControls.RJTextBox();
            this.dbText = new RJCodeAdvance.RJControls.RJTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 3;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Rabar_044", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(116, 386);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(367, 94);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "پاشەكەوت كردن";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fileName);
            this.flowLayoutPanel1.Controls.Add(this.sourceText);
            this.flowLayoutPanel1.Controls.Add(this.dbText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 89);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 252);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // fileName
            // 
            this.fileName.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.fileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fileName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.fileName.BorderRadius = 0;
            this.fileName.BorderSize = 2;
            this.fileName.Font = new System.Drawing.Font("Rabar_044", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileName.Location = new System.Drawing.Point(6, 6);
            this.fileName.Margin = new System.Windows.Forms.Padding(0);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.fileName.PasswordChar = false;
            this.fileName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fileName.PlaceholderText = "ناوی فایل";
            this.fileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileName.Size = new System.Drawing.Size(361, 75);
            this.fileName.TabIndex = 24;
            this.fileName.Texts = "";
            this.fileName.UnderlinedStyle = true;
            this.fileName._TextChanged += new System.EventHandler(this.username__TextChanged);
            // 
            // sourceText
            // 
            this.sourceText.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.sourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sourceText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.sourceText.BorderRadius = 0;
            this.sourceText.BorderSize = 2;
            this.sourceText.Font = new System.Drawing.Font("Rabar_044", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceText.Location = new System.Drawing.Point(6, 81);
            this.sourceText.Margin = new System.Windows.Forms.Padding(0);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.sourceText.PasswordChar = false;
            this.sourceText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sourceText.PlaceholderText = "ناوی سێرڤەر";
            this.sourceText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sourceText.Size = new System.Drawing.Size(361, 75);
            this.sourceText.TabIndex = 25;
            this.sourceText.Texts = "";
            this.sourceText.UnderlinedStyle = true;
            // 
            // dbText
            // 
            this.dbText.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.dbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dbText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.dbText.BorderRadius = 0;
            this.dbText.BorderSize = 2;
            this.dbText.Font = new System.Drawing.Font("Rabar_044", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbText.Location = new System.Drawing.Point(6, 156);
            this.dbText.Margin = new System.Windows.Forms.Padding(0);
            this.dbText.Multiline = true;
            this.dbText.Name = "dbText";
            this.dbText.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.dbText.PasswordChar = false;
            this.dbText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dbText.PlaceholderText = "ناوی داتابەیس";
            this.dbText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dbText.Size = new System.Drawing.Size(361, 75);
            this.dbText.TabIndex = 26;
            this.dbText.Texts = "";
            this.dbText.UnderlinedStyle = true;
            // 
            // ConnectionForrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 591);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(633, 647);
            this.MinimumSize = new System.Drawing.Size(633, 647);
            this.Name = "ConnectionForrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForrm";
            this.Load += new System.EventHandler(this.ConnectionForrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public CustomControls.RJControls.RJButton btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public RJCodeAdvance.RJControls.RJTextBox fileName;
        public RJCodeAdvance.RJControls.RJTextBox sourceText;
        public RJCodeAdvance.RJControls.RJTextBox dbText;
    }
}