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
            this.sickbtn = new FontAwesome.Sharp.IconButton();
            this.dashbtn = new FontAwesome.Sharp.IconButton();
            this.stubtn = new FontAwesome.Sharp.IconButton();
            this.disbtn = new FontAwesome.Sharp.IconButton();
            this.userbtn = new FontAwesome.Sharp.IconButton();
            this.phonNum = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
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
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(311, 1051);
            this.menuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sickbtn);
            this.flowLayoutPanel1.Controls.Add(this.dashbtn);
            this.flowLayoutPanel1.Controls.Add(this.stubtn);
            this.flowLayoutPanel1.Controls.Add(this.disbtn);
            this.flowLayoutPanel1.Controls.Add(this.userbtn);
            this.flowLayoutPanel1.Controls.Add(this.phonNum);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 1051);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sickbtn
            // 
            this.sickbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sickbtn.FlatAppearance.BorderSize = 0;
            this.sickbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sickbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sickbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sickbtn.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.sickbtn.IconColor = System.Drawing.Color.White;
            this.sickbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.sickbtn.IconSize = 42;
            this.sickbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sickbtn.Location = new System.Drawing.Point(3, 3);
            this.sickbtn.Name = "sickbtn";
            this.sickbtn.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.sickbtn.Size = new System.Drawing.Size(725, 114);
            this.sickbtn.TabIndex = 4;
            this.sickbtn.Text = "Reservations";
            this.sickbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sickbtn.UseVisualStyleBackColor = true;
            this.sickbtn.Click += new System.EventHandler(this.sickbtn_Click);
            // 
            // dashbtn
            // 
            this.dashbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashbtn.FlatAppearance.BorderSize = 0;
            this.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashbtn.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.dashbtn.IconColor = System.Drawing.Color.White;
            this.dashbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.dashbtn.IconSize = 42;
            this.dashbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashbtn.Location = new System.Drawing.Point(3, 123);
            this.dashbtn.Name = "dashbtn";
            this.dashbtn.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.dashbtn.Size = new System.Drawing.Size(725, 114);
            this.dashbtn.TabIndex = 1;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashbtn.UseVisualStyleBackColor = true;
            this.dashbtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // stubtn
            // 
            this.stubtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stubtn.FlatAppearance.BorderSize = 0;
            this.stubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stubtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stubtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stubtn.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.stubtn.IconColor = System.Drawing.Color.White;
            this.stubtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.stubtn.IconSize = 42;
            this.stubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stubtn.Location = new System.Drawing.Point(3, 243);
            this.stubtn.Name = "stubtn";
            this.stubtn.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.stubtn.Size = new System.Drawing.Size(725, 114);
            this.stubtn.TabIndex = 2;
            this.stubtn.Text = "Doctors";
            this.stubtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stubtn.UseVisualStyleBackColor = true;
            this.stubtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // disbtn
            // 
            this.disbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disbtn.FlatAppearance.BorderSize = 0;
            this.disbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disbtn.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.disbtn.IconColor = System.Drawing.Color.White;
            this.disbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.disbtn.IconSize = 42;
            this.disbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disbtn.Location = new System.Drawing.Point(3, 363);
            this.disbtn.Name = "disbtn";
            this.disbtn.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.disbtn.Size = new System.Drawing.Size(725, 114);
            this.disbtn.TabIndex = 3;
            this.disbtn.Text = "Patient";
            this.disbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.disbtn.UseVisualStyleBackColor = true;
            this.disbtn.Click += new System.EventHandler(this.disbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userbtn.FlatAppearance.BorderSize = 0;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userbtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.userbtn.IconColor = System.Drawing.Color.White;
            this.userbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.userbtn.IconSize = 42;
            this.userbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userbtn.Location = new System.Drawing.Point(3, 483);
            this.userbtn.Name = "userbtn";
            this.userbtn.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.userbtn.Size = new System.Drawing.Size(725, 114);
            this.userbtn.TabIndex = 5;
            this.userbtn.Text = "Visits";
            this.userbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userbtn.UseVisualStyleBackColor = true;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // phonNum
            // 
            this.phonNum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phonNum.FlatAppearance.BorderSize = 0;
            this.phonNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phonNum.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phonNum.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.phonNum.IconColor = System.Drawing.Color.White;
            this.phonNum.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.phonNum.IconSize = 42;
            this.phonNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phonNum.Location = new System.Drawing.Point(3, 603);
            this.phonNum.Name = "phonNum";
            this.phonNum.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.phonNum.Size = new System.Drawing.Size(725, 114);
            this.phonNum.TabIndex = 6;
            this.phonNum.Text = "Roles";
            this.phonNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phonNum.UseVisualStyleBackColor = true;
            this.phonNum.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 42;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 723);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 6);
            this.iconButton1.Size = new System.Drawing.Size(725, 114);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(311, 0);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1175, 743);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1631, 1051);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // mainFormId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1942, 1051);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
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

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton dashbtn;
        private FontAwesome.Sharp.IconButton stubtn;
        private FontAwesome.Sharp.IconButton phonNum;
        private FontAwesome.Sharp.IconButton userbtn;
        private FontAwesome.Sharp.IconButton sickbtn;
        private FontAwesome.Sharp.IconButton disbtn;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

