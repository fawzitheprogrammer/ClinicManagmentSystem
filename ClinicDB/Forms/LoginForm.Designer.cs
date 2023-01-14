namespace ClinicDB
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(451, 655);
            this.panel1.MinimumSize = new System.Drawing.Size(451, 655);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 655);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClinicDB.Properties.Resources.Asset_2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginPanel.Controls.Add(this.cancelBtn);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passText);
            this.loginPanel.Controls.Add(this.userText);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(451, 0);
            this.loginPanel.MaximumSize = new System.Drawing.Size(652, 655);
            this.loginPanel.MinimumSize = new System.Drawing.Size(652, 655);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(652, 655);
            this.loginPanel.TabIndex = 23;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Gray;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(89, 443);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(459, 63);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "CONNECT TO SERVER";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(90, 351);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(459, 63);
            this.loginBtn.TabIndex = 32;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passText
            // 
            this.passText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintText = "Password";
            this.passText.isPassword = true;
            this.passText.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.passText.LineIdleColor = System.Drawing.Color.Gray;
            this.passText.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.passText.LineThickness = 3;
            this.passText.Location = new System.Drawing.Point(90, 231);
            this.passText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passText.MaxLength = 32767;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(459, 58);
            this.passText.TabIndex = 31;
            this.passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userText
            // 
            this.userText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userText.HintText = "Username";
            this.userText.isPassword = false;
            this.userText.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.userText.LineIdleColor = System.Drawing.Color.Gray;
            this.userText.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.userText.LineThickness = 3;
            this.userText.Location = new System.Drawing.Point(90, 118);
            this.userText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userText.MaxLength = 32767;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(459, 58);
            this.userText.TabIndex = 30;
            this.userText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 214);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(152, 68);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "CLINIC SYSTEM";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(424, 424);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(246, 33);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "For a better health";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1121, 711);
            this.MinimumSize = new System.Drawing.Size(1121, 679);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginPanel;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}