namespace ClinicDB
{
    partial class SymptomsAdd
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
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.disCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.disText = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.rjButton1);
            this.mainPanel.Controls.Add(this.disCombo);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Controls.Add(this.disText);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Location = new System.Drawing.Point(34, 55);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(434, 642);
            this.mainPanel.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(36, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "DISEASE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(41, 529);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(348, 64);
            this.rjButton1.TabIndex = 27;
            this.rjButton1.Text = "Update";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // disCombo
            // 
            this.disCombo.BackColor = System.Drawing.Color.Transparent;
            this.disCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.disCombo.BorderThickness = 2;
            this.disCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.disCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.disCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.disCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disCombo.ItemHeight = 50;
            this.disCombo.ItemsAppearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.disCombo.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.disCombo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.disCombo.ItemsAppearance.SelectedFont = new System.Drawing.Font("Poppins Medium", 12F);
            this.disCombo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.disCombo.Location = new System.Drawing.Point(41, 274);
            this.disCombo.Margin = new System.Windows.Forms.Padding(0);
            this.disCombo.Name = "disCombo";
            this.disCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.disCombo.Size = new System.Drawing.Size(349, 56);
            this.disCombo.Sorted = true;
            this.disCombo.TabIndex = 26;
            this.disCombo.Tag = "";
            this.disCombo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(41, 445);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(348, 64);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // disText
            // 
            this.disText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.disText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.disText.BorderRadius = 0;
            this.disText.BorderSize = 2;
            this.disText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disText.Location = new System.Drawing.Point(42, 101);
            this.disText.Margin = new System.Windows.Forms.Padding(0);
            this.disText.Multiline = true;
            this.disText.Name = "disText";
            this.disText.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.disText.PasswordChar = false;
            this.disText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.disText.PlaceholderText = "";
            this.disText.Size = new System.Drawing.Size(348, 58);
            this.disText.TabIndex = 22;
            this.disText.Texts = "";
            this.disText.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "SYMPTOMS";
            // 
            // SymptomsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 726);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 782);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(543, 782);
            this.Name = "SymptomsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symptoms Add";
            this.Load += new System.EventHandler(this.SymptomsAdd_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        public CustomControls.RJControls.RJButton rjButton1;
        public CustomControls.RJControls.RJButton btnSave;
        public RJCodeAdvance.RJControls.RJTextBox disText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox disCombo;
    }
}