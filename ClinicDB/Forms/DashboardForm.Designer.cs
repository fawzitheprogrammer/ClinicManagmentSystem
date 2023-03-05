
namespace ClinicDB.Forms
{
    partial class DashboardForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.allPatient = new FontAwesome.Sharp.IconButton();
            this.allAdmin = new FontAwesome.Sharp.IconButton();
            this.allDoctors = new FontAwesome.Sharp.IconButton();
            this.allNurse = new FontAwesome.Sharp.IconButton();
            this.allStaffMembers = new FontAwesome.Sharp.IconButton();
            this.allMedicine = new FontAwesome.Sharp.IconButton();
            this.allDisease = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.allPatient, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.allAdmin, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.allDoctors, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.allNurse, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.allStaffMembers, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.allMedicine, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.allDisease, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1851, 1113);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // allPatient
            // 
            this.allPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(144)))), ((int)(((byte)(3)))));
            this.allPatient.FlatAppearance.BorderSize = 0;
            this.allPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allPatient.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPatient.ForeColor = System.Drawing.Color.White;
            this.allPatient.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.allPatient.IconColor = System.Drawing.Color.White;
            this.allPatient.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allPatient.IconSize = 80;
            this.allPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allPatient.Location = new System.Drawing.Point(175, 189);
            this.allPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allPatient.Name = "allPatient";
            this.allPatient.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allPatient.Size = new System.Drawing.Size(742, 177);
            this.allPatient.TabIndex = 6;
            this.allPatient.Text = "چارەخوازەكان : 100";
            this.allPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allPatient.UseVisualStyleBackColor = false;
            // 
            // allAdmin
            // 
            this.allAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(27)))), ((int)(((byte)(79)))));
            this.allAdmin.FlatAppearance.BorderSize = 0;
            this.allAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allAdmin.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAdmin.ForeColor = System.Drawing.Color.White;
            this.allAdmin.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.allAdmin.IconColor = System.Drawing.Color.White;
            this.allAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allAdmin.IconSize = 80;
            this.allAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allAdmin.Location = new System.Drawing.Point(923, 374);
            this.allAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allAdmin.Name = "allAdmin";
            this.allAdmin.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allAdmin.Size = new System.Drawing.Size(751, 177);
            this.allAdmin.TabIndex = 11;
            this.allAdmin.Text = "ئەدمینەكان : 100";
            this.allAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allAdmin.UseVisualStyleBackColor = false;
            // 
            // allDoctors
            // 
            this.allDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allDoctors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(115)))));
            this.allDoctors.FlatAppearance.BorderSize = 0;
            this.allDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allDoctors.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDoctors.ForeColor = System.Drawing.Color.White;
            this.allDoctors.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.allDoctors.IconColor = System.Drawing.Color.White;
            this.allDoctors.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allDoctors.IconSize = 80;
            this.allDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allDoctors.Location = new System.Drawing.Point(923, 189);
            this.allDoctors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allDoctors.Name = "allDoctors";
            this.allDoctors.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allDoctors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allDoctors.Size = new System.Drawing.Size(751, 177);
            this.allDoctors.TabIndex = 9;
            this.allDoctors.Text = "دكتۆرەكان : 100";
            this.allDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allDoctors.UseVisualStyleBackColor = false;
            // 
            // allNurse
            // 
            this.allNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allNurse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allNurse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(173)))));
            this.allNurse.FlatAppearance.BorderSize = 0;
            this.allNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allNurse.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allNurse.ForeColor = System.Drawing.Color.White;
            this.allNurse.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.allNurse.IconColor = System.Drawing.Color.White;
            this.allNurse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allNurse.IconSize = 80;
            this.allNurse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allNurse.Location = new System.Drawing.Point(175, 374);
            this.allNurse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allNurse.Name = "allNurse";
            this.allNurse.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allNurse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allNurse.Size = new System.Drawing.Size(742, 177);
            this.allNurse.TabIndex = 10;
            this.allNurse.Text = "پەرستارەكان : 100";
            this.allNurse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allNurse.UseVisualStyleBackColor = false;
            // 
            // allStaffMembers
            // 
            this.allStaffMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allStaffMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allStaffMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(131)))), ((int)(((byte)(194)))));
            this.allStaffMembers.FlatAppearance.BorderSize = 0;
            this.allStaffMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allStaffMembers.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStaffMembers.ForeColor = System.Drawing.Color.White;
            this.allStaffMembers.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.allStaffMembers.IconColor = System.Drawing.Color.White;
            this.allStaffMembers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allStaffMembers.IconSize = 80;
            this.allStaffMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allStaffMembers.Location = new System.Drawing.Point(175, 744);
            this.allStaffMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allStaffMembers.Name = "allStaffMembers";
            this.allStaffMembers.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allStaffMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allStaffMembers.Size = new System.Drawing.Size(742, 177);
            this.allStaffMembers.TabIndex = 8;
            this.allStaffMembers.Text = "ئەندامانی ستاف : 100";
            this.allStaffMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allStaffMembers.UseVisualStyleBackColor = false;
            // 
            // allMedicine
            // 
            this.allMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allMedicine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.allMedicine.FlatAppearance.BorderSize = 0;
            this.allMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allMedicine.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMedicine.ForeColor = System.Drawing.Color.White;
            this.allMedicine.IconChar = FontAwesome.Sharp.IconChar.ShieldVirus;
            this.allMedicine.IconColor = System.Drawing.Color.White;
            this.allMedicine.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allMedicine.IconSize = 80;
            this.allMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allMedicine.Location = new System.Drawing.Point(923, 559);
            this.allMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allMedicine.Name = "allMedicine";
            this.allMedicine.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allMedicine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allMedicine.Size = new System.Drawing.Size(751, 177);
            this.allMedicine.TabIndex = 7;
            this.allMedicine.Text = "دەرمانەكان : 100";
            this.allMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allMedicine.UseVisualStyleBackColor = false;
            // 
            // allDisease
            // 
            this.allDisease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allDisease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.allDisease.FlatAppearance.BorderSize = 0;
            this.allDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allDisease.Font = new System.Drawing.Font("Rabar_038", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDisease.ForeColor = System.Drawing.Color.White;
            this.allDisease.IconChar = FontAwesome.Sharp.IconChar.Viruses;
            this.allDisease.IconColor = System.Drawing.Color.White;
            this.allDisease.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.allDisease.IconSize = 80;
            this.allDisease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allDisease.Location = new System.Drawing.Point(175, 559);
            this.allDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allDisease.Name = "allDisease";
            this.allDisease.Padding = new System.Windows.Forms.Padding(50, 6, 0, 8);
            this.allDisease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allDisease.Size = new System.Drawing.Size(742, 177);
            this.allDisease.TabIndex = 12;
            this.allDisease.Text = "نەخۆشیەكان : 100";
            this.allDisease.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.allDisease.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1851, 1113);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1322, 929);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton allPatient;
        private FontAwesome.Sharp.IconButton allMedicine;
        private FontAwesome.Sharp.IconButton allStaffMembers;
        private FontAwesome.Sharp.IconButton allDoctors;
        private FontAwesome.Sharp.IconButton allNurse;
        private FontAwesome.Sharp.IconButton allAdmin;
        private FontAwesome.Sharp.IconButton allDisease;
    }
}