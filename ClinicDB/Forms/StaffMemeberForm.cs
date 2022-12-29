using ClinicD.FormAdd;
using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB.Forms
{
    public partial class StaffMemeberForm : Form
    {
        public StaffMemeberForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(ID);
            listBox.Items.Add(Names);
            listBox.Items.Add(Username);
            listBox.Items.Add(Password);
            listBox.Items.Add(Phone);
            listBox.Items.Add(Address);
            listBox.Items.Add(RoleID);
            listBox.Items.Add(Roles);

            CRUD.crud.loadData("st_getUsers", usersDG, listBox);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StaffMemeberAdd staff = new StaffMemeberAdd(this);
            staff.update.Enabled = false;
            openFormClass.getForm(staff, true);
        }

        private void usersDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = usersDG.Rows[e.RowIndex];

                if (row.Index != -1)
                {

                    if (usersDG.Columns[e.ColumnIndex].Name == "delete")

                    {

                        Hashtable ht = new Hashtable();
                        ht.Add("@ID", Convert.ToInt32(row.Cells["ID"].Value.ToString()));


                        crud.DataInsertUpdateDelete("st_deleteUser", ht, "Data deleted");
                        loadData();


                    }
                    else
                    {
                        StaffMemeberAdd staffMember = new StaffMemeberAdd(this);
                        staffMember.save.Enabled = false;
                        if (e.RowIndex != -1 && e.ColumnIndex != -1)
                        {
                            staffMember.usersID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                            staffMember.fullnameTxt.Texts = row.Cells["Names"].Value.ToString();
                            staffMember.userNameTxt.Texts = row.Cells["Username"].Value.ToString();
                            staffMember.passwordTxt.Texts = row.Cells["Password"].Value.ToString();
                            staffMember.phoneTxt.Texts = row.Cells["Phone"].Value.ToString();
                            staffMember.addressTxt.Texts = row.Cells["Address"].Value.ToString();
                            staffMember.roles.Text = row.Cells["Roles"].Value.ToString();
                        }
                        openFormClass.getForm(staffMember, true);
                    }
                }
            }
            catch (Exception)
            {
                //mainClass.showMessage(ex.ToString(),false);
            }
        }

        private void StaffMemeberForm_Load(object sender, EventArgs e)
        {

            // Default sort direction of users datagridview
            usersDG.Sort(usersDG.Columns[1], ListSortDirection.Ascending);
            //this.ID.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (search.Text == "" || search.Text == null)
                {
                    loadData();
                }
                else
                {
                    ListBox listBox = new ListBox();

                    listBox.Items.Add(ID);
                    listBox.Items.Add(Names);
                    listBox.Items.Add(Username);
                    listBox.Items.Add(Password);
                    listBox.Items.Add(Phone);
                    listBox.Items.Add(Address);
                    listBox.Items.Add(Roles);
                    CRUD.crud.searchData("st_searchUser", usersDG, listBox, search.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
