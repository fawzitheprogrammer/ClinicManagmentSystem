namespace ClinicDB.Forms
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.patientDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stastusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStudentBindingSource1
            // 
            this.tblStudentBindingSource1.DataMember = "tblStudent";
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 74);
            this.panel1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Animated = true;
            this.search.BorderRadius = 3;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(4, 10);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search.PlaceholderText = "";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(1182, 55);
            this.search.TabIndex = 8;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress_1);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1188, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(57, 74);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(1245, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(57, 74);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 175.6098F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.FillWeight = 175.6098F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.FillWeight = 24F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 150;
            // 
            // patientDG
            // 
            this.patientDG.AllowUserToAddRows = false;
            this.patientDG.AllowUserToDeleteRows = false;
            this.patientDG.AllowUserToResizeColumns = false;
            this.patientDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.patientDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patientDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.patientDG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.patientDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.patientDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rabar_044", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.patientDG.ColumnHeadersHeight = 60;
            this.patientDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patientDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.patientCol,
            this.fatherCol,
            this.TurnNumber,
            this.appointmentDateCol,
            this.phoneCol,
            this.ageCol,
            this.doctorCol,
            this.DoctorIDCol,
            this.StatusCol,
            this.stastusID,
            this.delete});
            this.patientDG.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.patientDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDG.EnableHeadersVisualStyles = false;
            this.patientDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.patientDG.Location = new System.Drawing.Point(0, 74);
            this.patientDG.Name = "patientDG";
            this.patientDG.ReadOnly = true;
            this.patientDG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.patientDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.patientDG.RowHeadersVisible = false;
            this.patientDG.RowHeadersWidth = 51;
            this.patientDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.patientDG.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.patientDG.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.patientDG.RowTemplate.Height = 27;
            this.patientDG.Size = new System.Drawing.Size(1302, 796);
            this.patientDG.TabIndex = 0;
            this.patientDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDG_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "#";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 64;
            // 
            // patientCol
            // 
            this.patientCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientCol.HeaderText = "چارەخواز";
            this.patientCol.MinimumWidth = 6;
            this.patientCol.Name = "patientCol";
            this.patientCol.ReadOnly = true;
            // 
            // fatherCol
            // 
            this.fatherCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fatherCol.HeaderText = "ناوی بەخێوكەر";
            this.fatherCol.MinimumWidth = 6;
            this.fatherCol.Name = "fatherCol";
            this.fatherCol.ReadOnly = true;
            // 
            // TurnNumber
            // 
            this.TurnNumber.HeaderText = "ژمارەی سەرە";
            this.TurnNumber.MinimumWidth = 8;
            this.TurnNumber.Name = "TurnNumber";
            this.TurnNumber.ReadOnly = true;
            // 
            // appointmentDateCol
            // 
            this.appointmentDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointmentDateCol.HeaderText = "بەرواری چاوپێكەوتن";
            this.appointmentDateCol.MinimumWidth = 6;
            this.appointmentDateCol.Name = "appointmentDateCol";
            this.appointmentDateCol.ReadOnly = true;
            // 
            // phoneCol
            // 
            this.phoneCol.HeaderText = "ژمارەی موبایل";
            this.phoneCol.MinimumWidth = 8;
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.ReadOnly = true;
            // 
            // ageCol
            // 
            this.ageCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ageCol.HeaderText = "تەمەن";
            this.ageCol.MinimumWidth = 6;
            this.ageCol.Name = "ageCol";
            this.ageCol.ReadOnly = true;
            this.ageCol.Width = 108;
            // 
            // doctorCol
            // 
            this.doctorCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doctorCol.FillWeight = 69.91109F;
            this.doctorCol.HeaderText = "ناوی دكتۆر";
            this.doctorCol.MinimumWidth = 6;
            this.doctorCol.Name = "doctorCol";
            this.doctorCol.ReadOnly = true;
            // 
            // DoctorIDCol
            // 
            this.DoctorIDCol.HeaderText = "DoctorI D";
            this.DoctorIDCol.MinimumWidth = 6;
            this.DoctorIDCol.Name = "DoctorIDCol";
            this.DoctorIDCol.ReadOnly = true;
            this.DoctorIDCol.Visible = false;
            // 
            // StatusCol
            // 
            this.StatusCol.HeaderText = "بار";
            this.StatusCol.MinimumWidth = 8;
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            // 
            // stastusID
            // 
            this.stastusID.HeaderText = "StastusID";
            this.stastusID.MinimumWidth = 8;
            this.stastusID.Name = "stastusID";
            this.stastusID.ReadOnly = true;
            this.stastusID.Visible = false;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "❌";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 80;
            // 
            // PatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1302, 870);
            this.Controls.Add(this.patientDG);
            this.Controls.Add(this.panel1);
            this.Name = "PatientForm";
            this.Text = "Patient Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffMemeberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private System.Windows.Forms.BindingSource tblStudentBindingSource1;
        public FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2TextBox search;
        public System.Windows.Forms.DataGridView patientDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stastusID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
    }
}