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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userRadioButton = new CustomControls.RJControls.RJRadioButton();
            this.adminRadioButton = new CustomControls.RJControls.RJRadioButton();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(422, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 100);
            this.panel2.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-58, 332);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(486, 54);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "CLINIC SYSTEM";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(-58, 364);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(486, 54);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "For a better health";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClinicDB.Properties.Resources.Asset_2;
            this.pictureBox1.Location = new System.Drawing.Point(88, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(751, 237);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.userRadioButton);
            this.loginPanel.Controls.Add(this.adminRadioButton);
            this.loginPanel.Controls.Add(this.cancelBtn);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passText);
            this.loginPanel.Controls.Add(this.userText);
            this.loginPanel.Location = new System.Drawing.Point(422, 6);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(557, 515);
            this.loginPanel.TabIndex = 23;
            // 
            // userRadioButton
            // 
            this.userRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userRadioButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.userRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadioButton.Location = new System.Drawing.Point(222, 69);
            this.userRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userRadioButton.Size = new System.Drawing.Size(108, 34);
            this.userRadioButton.TabIndex = 35;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminRadioButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.adminRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(108, 69);
            this.adminRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminRadioButton.Size = new System.Drawing.Size(108, 34);
            this.adminRadioButton.TabIndex = 34;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.adminRadioButton.UseVisualStyleBackColor = true;
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
            this.cancelBtn.Location = new System.Drawing.Point(110, 395);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(337, 51);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "CANCEL";
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
            this.loginBtn.Location = new System.Drawing.Point(111, 322);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(337, 51);
            this.loginBtn.TabIndex = 32;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passText
            // 
            this.passText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintText = "Password";
            this.passText.isPassword = false;
            this.passText.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.passText.LineIdleColor = System.Drawing.Color.Gray;
            this.passText.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.passText.LineThickness = 3;
            this.passText.Location = new System.Drawing.Point(111, 226);
            this.passText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passText.MaxLength = 32767;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(337, 46);
            this.passText.TabIndex = 31;
            this.passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userText
            // 
            this.userText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
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
            this.userText.Location = new System.Drawing.Point(111, 135);
            this.userText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userText.MaxLength = 32767;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(337, 46);
            this.userText.TabIndex = 30;
            this.userText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(981, 533);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 580);
            this.MinimumSize = new System.Drawing.Size(999, 580);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel loginPanel;
        private CustomControls.RJControls.RJRadioButton userRadioButton;
        private CustomControls.RJControls.RJRadioButton adminRadioButton;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userText;
    }
}