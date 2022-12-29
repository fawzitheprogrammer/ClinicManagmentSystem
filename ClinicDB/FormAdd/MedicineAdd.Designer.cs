namespace ClinicDB
{
    partial class MedicineAdd
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comTxt = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.medTxt = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.type);
            this.mainPanel.Controls.Add(this.comTxt);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.rjButton1);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Controls.Add(this.medTxt);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Location = new System.Drawing.Point(30, 44);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(386, 577);
            this.mainPanel.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(35, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "TYPE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.type.BorderThickness = 2;
            this.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.type.ItemHeight = 50;
            this.type.Items.AddRange(new object[] {
            "External",
            "Internal"});
            this.type.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.type.Location = new System.Drawing.Point(37, 327);
            this.type.Margin = new System.Windows.Forms.Padding(0);
            this.type.Name = "type";
            this.type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.type.Size = new System.Drawing.Size(309, 56);
            this.type.Sorted = true;
            this.type.TabIndex = 30;
            this.type.Tag = "";
            this.type.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // comTxt
            // 
            this.comTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comTxt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.comTxt.BorderRadius = 0;
            this.comTxt.BorderSize = 2;
            this.comTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comTxt.Location = new System.Drawing.Point(37, 185);
            this.comTxt.Margin = new System.Windows.Forms.Padding(0);
            this.comTxt.Multiline = true;
            this.comTxt.Name = "comTxt";
            this.comTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.comTxt.PasswordChar = false;
            this.comTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.comTxt.PlaceholderText = "";
            this.comTxt.Size = new System.Drawing.Size(309, 46);
            this.comTxt.TabIndex = 28;
            this.comTxt.Texts = "";
            this.comTxt.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(32, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "COMPANY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 3;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(37, 493);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(309, 51);
            this.rjButton1.TabIndex = 27;
            this.rjButton1.Text = "Update";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
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
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(37, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 51);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // medTxt
            // 
            this.medTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.medTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medTxt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.medTxt.BorderRadius = 0;
            this.medTxt.BorderSize = 2;
            this.medTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medTxt.Location = new System.Drawing.Point(37, 59);
            this.medTxt.Margin = new System.Windows.Forms.Padding(0);
            this.medTxt.Multiline = true;
            this.medTxt.Name = "medTxt";
            this.medTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.medTxt.PasswordChar = false;
            this.medTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.medTxt.PlaceholderText = "";
            this.medTxt.Size = new System.Drawing.Size(309, 46);
            this.medTxt.TabIndex = 22;
            this.medTxt.Texts = "";
            this.medTxt.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "MEDICINE";
            // 
            // MedicineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 669);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedicineAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        public CustomControls.RJControls.RJButton rjButton1;
        public CustomControls.RJControls.RJButton btnSave;
        public RJCodeAdvance.RJControls.RJTextBox medTxt;
        private System.Windows.Forms.Label label2;
        public RJCodeAdvance.RJControls.RJTextBox comTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox type;
    }
}