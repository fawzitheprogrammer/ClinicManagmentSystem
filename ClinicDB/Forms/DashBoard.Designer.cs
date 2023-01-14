namespace ClinicDB.Forms
{
    partial class mainFormId
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.medBtn = new FontAwesome.Sharp.IconButton();
            this.sickbtn = new FontAwesome.Sharp.IconButton();
            this.disBtn = new FontAwesome.Sharp.IconButton();
            this.dashbtn = new FontAwesome.Sharp.IconButton();
            this.staffBtn = new FontAwesome.Sharp.IconButton();
            this.roles = new FontAwesome.Sharp.IconButton();
            this.patientBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(346, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1839, 1314);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.menuPanel.Controls.Add(this.flowLayoutPanel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(346, 1314);
            this.menuPanel.TabIndex = 0;
            // 
            // medBtn
            // 
            this.medBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.medBtn.FlatAppearance.BorderSize = 0;
            this.medBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medBtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.medBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medBtn.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleAlt;
            this.medBtn.IconColor = System.Drawing.Color.White;
            this.medBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.medBtn.IconSize = 45;
            this.medBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medBtn.Location = new System.Drawing.Point(3, 200);
            this.medBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medBtn.Name = "medBtn";
            this.medBtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.medBtn.Size = new System.Drawing.Size(816, 90);
            this.medBtn.TabIndex = 5;
            this.medBtn.Text = "Medicines";
            this.medBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.medBtn.UseVisualStyleBackColor = true;
            this.medBtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // sickbtn
            // 
            this.sickbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sickbtn.FlatAppearance.BorderSize = 0;
            this.sickbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sickbtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.sickbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sickbtn.IconChar = FontAwesome.Sharp.IconChar.SadTear;
            this.sickbtn.IconColor = System.Drawing.Color.White;
            this.sickbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.sickbtn.IconSize = 45;
            this.sickbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sickbtn.Location = new System.Drawing.Point(3, 396);
            this.sickbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sickbtn.Name = "sickbtn";
            this.sickbtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.sickbtn.Size = new System.Drawing.Size(816, 90);
            this.sickbtn.TabIndex = 14;
            this.sickbtn.Text = "Symptoms";
            this.sickbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sickbtn.UseVisualStyleBackColor = true;
            this.sickbtn.Click += new System.EventHandler(this.sickbtn_Click_1);
            // 
            // disBtn
            // 
            this.disBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disBtn.FlatAppearance.BorderSize = 0;
            this.disBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disBtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.disBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disBtn.IconChar = FontAwesome.Sharp.IconChar.Virus;
            this.disBtn.IconColor = System.Drawing.Color.White;
            this.disBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.disBtn.IconSize = 45;
            this.disBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disBtn.Location = new System.Drawing.Point(3, 298);
            this.disBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disBtn.Name = "disBtn";
            this.disBtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.disBtn.Size = new System.Drawing.Size(816, 90);
            this.disBtn.TabIndex = 8;
            this.disBtn.Text = "Diseases";
            this.disBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.disBtn.UseVisualStyleBackColor = true;
            this.disBtn.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // dashbtn
            // 
            this.dashbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashbtn.FlatAppearance.BorderSize = 0;
            this.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.dashbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashbtn.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.dashbtn.IconColor = System.Drawing.Color.White;
            this.dashbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.dashbtn.IconSize = 45;
            this.dashbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbtn.Location = new System.Drawing.Point(3, 4);
            this.dashbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashbtn.Name = "dashbtn";
            this.dashbtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.dashbtn.Size = new System.Drawing.Size(816, 90);
            this.dashbtn.TabIndex = 1;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashbtn.UseVisualStyleBackColor = true;
            this.dashbtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.staffBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staffBtn.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.staffBtn.IconColor = System.Drawing.Color.White;
            this.staffBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.staffBtn.IconSize = 45;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(3, 494);
            this.staffBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.staffBtn.Size = new System.Drawing.Size(816, 90);
            this.staffBtn.TabIndex = 2;
            this.staffBtn.Text = "Staff Member";
            this.staffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // roles
            // 
            this.roles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roles.FlatAppearance.BorderSize = 0;
            this.roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roles.Font = new System.Drawing.Font("Poppins", 11F);
            this.roles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roles.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.roles.IconColor = System.Drawing.Color.White;
            this.roles.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.roles.IconSize = 45;
            this.roles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roles.Location = new System.Drawing.Point(3, 592);
            this.roles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roles.Name = "roles";
            this.roles.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.roles.Size = new System.Drawing.Size(816, 90);
            this.roles.TabIndex = 12;
            this.roles.Text = "Roles";
            this.roles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roles.UseVisualStyleBackColor = true;
            this.roles.Click += new System.EventHandler(this.phonNum_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.patientBtn.FlatAppearance.BorderSize = 0;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.patientBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientBtn.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.patientBtn.IconColor = System.Drawing.Color.White;
            this.patientBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.patientBtn.IconSize = 45;
            this.patientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.Location = new System.Drawing.Point(3, 102);
            this.patientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.patientBtn.Size = new System.Drawing.Size(816, 90);
            this.patientBtn.TabIndex = 3;
            this.patientBtn.Text = "Patient";
            this.patientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.disbtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Poppins", 11F);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 690);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.iconButton1.Size = new System.Drawing.Size(816, 90);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.dashbtn);
            this.flowLayoutPanel1.Controls.Add(this.patientBtn);
            this.flowLayoutPanel1.Controls.Add(this.medBtn);
            this.flowLayoutPanel1.Controls.Add(this.disBtn);
            this.flowLayoutPanel1.Controls.Add(this.sickbtn);
            this.flowLayoutPanel1.Controls.Add(this.staffBtn);
            this.flowLayoutPanel1.Controls.Add(this.roles);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 1314);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // mainFormId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(2185, 1314);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(2155, 1271);
            this.Name = "mainFormId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainFormId_Load);
            this.Resize += new System.EventHandler(this.mainFormId_Resize);
            this.menuPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel menuPanel;
        public FontAwesome.Sharp.IconButton staffBtn;
        public FontAwesome.Sharp.IconButton patientBtn;
        public FontAwesome.Sharp.IconButton sickbtn;
        public FontAwesome.Sharp.IconButton dashbtn;
        public FontAwesome.Sharp.IconButton disBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        public FontAwesome.Sharp.IconButton roles;
        public FontAwesome.Sharp.IconButton medBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

