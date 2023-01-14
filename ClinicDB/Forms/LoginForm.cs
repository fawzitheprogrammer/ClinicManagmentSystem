using ClinicDB.Forms;
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
using Authentication;
using System.Collections;

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

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            // C:\Users\SOFTWARE\Documents
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(MainClass.mainClass.checkControls(loginPanel).Count > 0)
            {
                MainClass.mainClass.showMessage("Please fill out all fields to continue", false);
            }
            else
            {

                Hashtable ht = new Hashtable();

                ht.Add("@username", userText.Text);
                ht.Add("@pass", passText.Text);

              if (login.getLoginDetails("st_loginAuth",ht))
                {
                    mainFormId mf = new mainFormId();
                    mf.ShowDialog();
                    this.Hide();
                }

            }
        }

       
    }
}
