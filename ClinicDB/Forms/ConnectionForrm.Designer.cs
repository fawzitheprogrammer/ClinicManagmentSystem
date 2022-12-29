
namespace ClinicDB.Forms
{
    partial class ConnectionForrm
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
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.username = new RJCodeAdvance.RJControls.RJTextBox();
            this.sourceText = new RJCodeAdvance.RJControls.RJTextBox();
            this.dbText = new RJCodeAdvance.RJControls.RJTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(103, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(326, 75);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.username);
            this.flowLayoutPanel1.Controls.Add(this.sourceText);
            this.flowLayoutPanel1.Controls.Add(this.dbText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 71);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 202);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // username
            // 
            this.username.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.username.BorderRadius = 0;
            this.username.BorderSize = 2;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.Location = new System.Drawing.Point(5, 5);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "File name";
            this.username.Size = new System.Drawing.Size(309, 60);
            this.username.TabIndex = 24;
            this.username.Texts = "";
            this.username.UnderlinedStyle = true;
            this.username._TextChanged += new System.EventHandler(this.username__TextChanged);
            // 
            // sourceText
            // 
            this.sourceText.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.sourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sourceText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.sourceText.BorderRadius = 0;
            this.sourceText.BorderSize = 2;
            this.sourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sourceText.Location = new System.Drawing.Point(5, 65);
            this.sourceText.Margin = new System.Windows.Forms.Padding(0);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.sourceText.PasswordChar = false;
            this.sourceText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sourceText.PlaceholderText = "Server Name";
            this.sourceText.Size = new System.Drawing.Size(309, 60);
            this.sourceText.TabIndex = 25;
            this.sourceText.Texts = "";
            this.sourceText.UnderlinedStyle = true;
            // 
            // dbText
            // 
            this.dbText.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.dbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dbText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.dbText.BorderRadius = 0;
            this.dbText.BorderSize = 2;
            this.dbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dbText.Location = new System.Drawing.Point(5, 125);
            this.dbText.Margin = new System.Windows.Forms.Padding(0);
            this.dbText.Multiline = true;
            this.dbText.Name = "dbText";
            this.dbText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.dbText.PasswordChar = false;
            this.dbText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dbText.PlaceholderText = "Database";
            this.dbText.Size = new System.Drawing.Size(309, 60);
            this.dbText.TabIndex = 26;
            this.dbText.Texts = "";
            this.dbText.UnderlinedStyle = true;
            // 
            // ConnectionForrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 482);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(565, 529);
            this.MinimumSize = new System.Drawing.Size(565, 529);
            this.Name = "ConnectionForrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForrm";
            this.Load += new System.EventHandler(this.ConnectionForrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public CustomControls.RJControls.RJButton btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public RJCodeAdvance.RJControls.RJTextBox username;
        public RJCodeAdvance.RJControls.RJTextBox sourceText;
        public RJCodeAdvance.RJControls.RJTextBox dbText;
    }
}