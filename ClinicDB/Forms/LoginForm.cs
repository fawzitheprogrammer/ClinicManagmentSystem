﻿using ClinicDB.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainFormId db = new mainFormId();
            db.ShowDialog();
            this.Close();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cms_connect";
            if (!File.Exists(path))
            {
                ConnectionForrm connection = new ConnectionForrm();
                connection.ShowDialog();
            }
            else
            {

                MainClass.mainClass.showMessage("Connnected", true);

            }
        }
    }
}
