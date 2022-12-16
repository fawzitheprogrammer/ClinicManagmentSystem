using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB
{
    public partial class Roles : Form
    {
       
        public Roles()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(roleIDGV);
            listBox.Items.Add(roleGV);
            CRUD.crud.loadData("st_getRoles", rolesDg, listBox);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

            RolesAdd rolesAdd = new RolesAdd(this);
            rolesAdd.rjButton1.Enabled = false;
            openFormClass.getForm(rolesAdd, true);

        }

        private void user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void user_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = rolesDg.Rows[e.RowIndex];

                if (row.Index != -1)
                {

                    if (rolesDg.Columns[e.ColumnIndex].Name == "delete")

                    {

                        Hashtable ht = new Hashtable();
                        ht.Add("@id", Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString()));


                        crud.DataInsertUpdateDelete("st_deleteRoles", ht);
                        mainClass.showMessage("Data deleted", true);
                        loadData();


                    }
                    else
                    {
                        RolesAdd rolesAdd = new RolesAdd(this);
                        rolesAdd.btnSave.Enabled = false;
                        if (e.RowIndex != -1 && e.ColumnIndex != -1)
                        {
                            rolesAdd.roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                            rolesAdd.roleText.Texts = row.Cells["roleGV"].Value.ToString();
                        }
                        openFormClass.getForm(rolesAdd, true);
                    }
                }
            }catch(Exception ex)
            {
                //mainClass.showMessage(ex.ToString(),false);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(roleIDGV);
            listBox.Items.Add(roleGV);
            CRUD.crud.searchData("st_searchRoles", rolesDg, listBox);
        }
    }
}
