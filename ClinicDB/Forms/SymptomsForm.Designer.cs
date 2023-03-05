namespace ClinicDB
{
    partial class SymptomsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.symptomsDg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.symptomsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // symptomsDg
            // 
            this.symptomsDg.AllowUserToAddRows = false;
            this.symptomsDg.AllowUserToDeleteRows = false;
            this.symptomsDg.AllowUserToResizeColumns = false;
            this.symptomsDg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.symptomsDg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.symptomsDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.symptomsDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.symptomsDg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.symptomsDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.symptomsDg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.symptomsDg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rabar_044", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.symptomsDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.symptomsDg.ColumnHeadersHeight = 60;
            this.symptomsDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.symptomsDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symptomsID,
            this.symptomsGV,
            this.diseaseGV,
            this.diseaseIDGV,
            this.delete});
            this.symptomsDg.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.symptomsDg.DefaultCellStyle = dataGridViewCellStyle3;
            this.symptomsDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symptomsDg.EnableHeadersVisualStyles = false;
            this.symptomsDg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.symptomsDg.Location = new System.Drawing.Point(0, 74);
            this.symptomsDg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.symptomsDg.Name = "symptomsDg";
            this.symptomsDg.ReadOnly = true;
            this.symptomsDg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.symptomsDg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.symptomsDg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.symptomsDg.RowHeadersVisible = false;
            this.symptomsDg.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.symptomsDg.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.symptomsDg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.symptomsDg.RowTemplate.Height = 27;
            this.symptomsDg.Size = new System.Drawing.Size(1302, 796);
            this.symptomsDg.TabIndex = 9;
            this.symptomsDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_CellContentClick);
            this.symptomsDg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.user_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 74);
            this.panel1.TabIndex = 8;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
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
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search.PlaceholderText = "";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(1182, 55);
            this.search.TabIndex = 8;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1187, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(51, 74);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(1238, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(64, 74);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ClinicDB.Properties.Resources.Asset_5_2x;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 519;
            // 
            // symptomsID
            // 
            this.symptomsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symptomsID.FillWeight = 20F;
            this.symptomsID.HeaderText = "#";
            this.symptomsID.MinimumWidth = 4;
            this.symptomsID.Name = "symptomsID";
            this.symptomsID.ReadOnly = true;
            // 
            // symptomsGV
            // 
            this.symptomsGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symptomsGV.FillWeight = 124.1379F;
            this.symptomsGV.HeaderText = "نیشانە";
            this.symptomsGV.MinimumWidth = 6;
            this.symptomsGV.Name = "symptomsGV";
            this.symptomsGV.ReadOnly = true;
            // 
            // diseaseGV
            // 
            this.diseaseGV.HeaderText = "نەخۆشی";
            this.diseaseGV.MinimumWidth = 8;
            this.diseaseGV.Name = "diseaseGV";
            this.diseaseGV.ReadOnly = true;
            // 
            // diseaseIDGV
            // 
            this.diseaseIDGV.HeaderText = "DiseaseID";
            this.diseaseIDGV.MinimumWidth = 8;
            this.diseaseIDGV.Name = "diseaseIDGV";
            this.diseaseIDGV.ReadOnly = true;
            this.diseaseIDGV.Visible = false;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.delete.HeaderText = "❌";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // SymptomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 870);
            this.Controls.Add(this.symptomsDg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SymptomsForm";
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        public System.Windows.Forms.DataGridView symptomsDg;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseIDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
    }
}