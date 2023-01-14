using ClinicDB.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainClass;
using System.Collections;

namespace ClinicD.FormAdd
{
    public partial class StaffMemeberAdd : Form
    {

        StaffMemeberForm staffMember;

        public int usersID;


        public StaffMemeberAdd(StaffMemeberForm staff)
        {
            InitializeComponent();
            staffMember = staff;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (mainClass.checkControls(panel1).Count > 0)
            {
                mainClass.showMessage("Please fill out all fields.", false);
            }
            else
            {

                Hashtable ht = new Hashtable();
                ht.Add("@name", fullnameTxt.Texts);
                ht.Add("@username", userNameTxt.Texts);
                ht.Add("@password", passwordTxt.Texts);
                ht.Add("@phone", phoneTxt.Texts);
                ht.Add("@address", addressTxt.Texts);
                ht.Add("@roleID", Convert.ToInt32(roles.SelectedValue.ToString()));

                CRUD.crud.DataInsertUpdateDelete("st_insertUsers",ht, "Data inserted");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffMemeberAdd_Load(object sender, EventArgs e)
        {
      
            try
            {
                CRUD.crud.loadRole("st_getRoles", roles, "ID", "Role");
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if(mainClass.checkControls(panel1).Count > 0)
            {

            }
            else
            {
                Hashtable ht = new Hashtable();
                ht.Add("@name", fullnameTxt.Texts);
                ht.Add("@username", userNameTxt.Texts);
                ht.Add("@password", passwordTxt.Texts);
                ht.Add("@phone", phoneTxt.Texts);
                ht.Add("@address", addressTxt.Texts);
                ht.Add("@roleID", Convert.ToInt32(roles.SelectedValue.ToString()));
                ht.Add("@id", usersID);



                string theRecord = fullnameTxt.Texts + " updated successfully in the system.";
                CRUD.crud.DataInsertUpdateDelete("st_updateUsers", ht, theRecord);
                staffMember.loadData();
                this.Close();
            }
        }
    }
}

