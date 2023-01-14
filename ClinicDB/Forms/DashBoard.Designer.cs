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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dashbtn = new FontAwesome.Sharp.IconButton();
            this.disbtn = new FontAwesome.Sharp.IconButton();
            this.medBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.sickbtn = new FontAwesome.Sharp.IconButton();
            this.stubtn = new FontAwesome.Sharp.IconButton();
            this.phonNum = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.menuPanel.Controls.Add(this.flowLayoutPanel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(350, 1314);
            this.menuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dashbtn);
            this.flowLayoutPanel1.Controls.Add(this.disbtn);
            this.flowLayoutPanel1.Controls.Add(this.medBtn);
            this.flowLayoutPanel1.Controls.Add(this.iconButton2);
            this.flowLayoutPanel1.Controls.Add(this.sickbtn);
            this.flowLayoutPanel1.Controls.Add(this.stubtn);
            this.flowLayoutPanel1.Controls.Add(this.phonNum);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 1314);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(350, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1835, 1314);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.dashbtn.Size = new System.Drawing.Size(816, 80);
            this.dashbtn.TabIndex = 1;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashbtn.UseVisualStyleBackColor = true;
            this.dashbtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // disbtn
            // 
            this.disbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disbtn.FlatAppearance.BorderSize = 0;
            this.disbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disbtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.disbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disbtn.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.disbtn.IconColor = System.Drawing.Color.White;
            this.disbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.disbtn.IconSize = 45;
            this.disbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disbtn.Location = new System.Drawing.Point(3, 92);
            this.disbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disbtn.Name = "disbtn";
            this.disbtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.disbtn.Size = new System.Drawing.Size(816, 80);
            this.disbtn.TabIndex = 3;
            this.disbtn.Text = "Patient";
            this.disbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.disbtn.UseVisualStyleBackColor = true;
            this.disbtn.Click += new System.EventHandler(this.disbtn_Click);
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
            this.medBtn.Location = new System.Drawing.Point(3, 180);
            this.medBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medBtn.Name = "medBtn";
            this.medBtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.medBtn.Size = new System.Drawing.Size(816, 80);
            this.medBtn.TabIndex = 5;
            this.medBtn.Text = "Medicines";
            this.medBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.medBtn.UseVisualStyleBackColor = true;
            this.medBtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Poppins", 11F);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Virus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 45;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 268);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.iconButton2.Size = new System.Drawing.Size(816, 80);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Diseases";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
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
            this.sickbtn.Location = new System.Drawing.Point(3, 356);
            this.sickbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sickbtn.Name = "sickbtn";
            this.sickbtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.sickbtn.Size = new System.Drawing.Size(816, 80);
            this.sickbtn.TabIndex = 14;
            this.sickbtn.Text = "Symptoms";
            this.sickbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sickbtn.UseVisualStyleBackColor = true;
            this.sickbtn.Click += new System.EventHandler(this.sickbtn_Click_1);
            // 
            // stubtn
            // 
            this.stubtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stubtn.FlatAppearance.BorderSize = 0;
            this.stubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stubtn.Font = new System.Drawing.Font("Poppins", 11F);
            this.stubtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stubtn.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.stubtn.IconColor = System.Drawing.Color.White;
            this.stubtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.stubtn.IconSize = 45;
            this.stubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stubtn.Location = new System.Drawing.Point(3, 444);
            this.stubtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stubtn.Name = "stubtn";
            this.stubtn.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.stubtn.Size = new System.Drawing.Size(816, 80);
            this.stubtn.TabIndex = 2;
            this.stubtn.Text = "Staff Member";
            this.stubtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stubtn.UseVisualStyleBackColor = true;
            this.stubtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // phonNum
            // 
            this.phonNum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phonNum.FlatAppearance.BorderSize = 0;
            this.phonNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phonNum.Font = new System.Drawing.Font("Poppins", 11F);
            this.phonNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phonNum.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.phonNum.IconColor = System.Drawing.Color.White;
            this.phonNum.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.phonNum.IconSize = 45;
            this.phonNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phonNum.Location = new System.Drawing.Point(3, 532);
            this.phonNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonNum.Name = "phonNum";
            this.phonNum.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.phonNum.Size = new System.Drawing.Size(816, 80);
            this.phonNum.TabIndex = 12;
            this.phonNum.Text = "Roles";
            this.phonNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phonNum.UseVisualStyleBackColor = true;
            this.phonNum.Click += new System.EventHandler(this.phonNum_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(3, 620);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(17, 6, 0, 8);
            this.iconButton1.Size = new System.Drawing.Size(816, 80);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // mainFormId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(2185, 1314);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(2155, 1271);
            this.Name = "mainFormId";
            this.ShowIcon = false;
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

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton dashbtn;
        private FontAwesome.Sharp.IconButton stubtn;
        private FontAwesome.Sharp.IconButton medBtn;
        private FontAwesome.Sharp.IconButton disbtn;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton sickbtn;
        private FontAwesome.Sharp.IconButton phonNum;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

