using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainClass;
using CRUD;
using System.Collections;

namespace ClinicDB
{
    public partial class RolesAdd : Form
    {

        ClinicDB.Roles roles;

        public int roleID;

        public RolesAdd(ClinicDB.Roles role)
        {
            InitializeComponent();
            roles = role;
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mainClass.checkControls(mainPanel).Count > 0)
            {
                mainClass.showMessage("Please fill the blank fields", false);
                mainClass.resetEnable(mainPanel);
            }
            else
            {

                Hashtable ht = new Hashtable();
                ht.Add("@name", roleText.Texts);

                crud.DataInsertUpdateDelete("st_insertRoles", ht, "Data inserted");
                mainClass.resetEnable(mainPanel);
                roles.loadData();
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add("@name", roleText.Texts);
            ht.Add("@Id", roleID);

            /*   ListBox paramList = new ListBox();
               paramList.Items.Add("@name");
               paramList.Items.Add("@id");
               ListBox valueList = new ListBox();
               valueList.Items.Add(roleText.Texts);
               valueList.Items.Add(roleID);*/

            string theRecord = roleText.Texts + " updated successfully in the system.";
            crud.DataInsertUpdateDelete("st_updateRoles", ht,theRecord);
            roles.loadData();
            this.Close();
        }
    }
}
