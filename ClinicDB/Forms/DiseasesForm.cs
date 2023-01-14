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
    public partial class DiseasesForm : Form
    {
       
        public DiseasesForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(diseaseID);
            listBox.Items.Add(diseaseGV);
            CRUD.crud.loadData("st_getDisease", rolesDg, listBox);
        }

        public void searchData()
        {
            if (search.Text == "" || search.Text == null)
            {
                loadData();
            }
            else
            {
                ListBox listBox = new ListBox();

                listBox.Items.Add(diseaseID);
                listBox.Items.Add(diseaseGV);
                CRUD.crud.searchData("st_seacrhDisease", rolesDg, listBox, search.Text);
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

            DiseaseAdd diseaseAdd = new DiseaseAdd(this);
            diseaseAdd.rjButton1.Enabled = false;
            openFormClass.getForm(diseaseAdd, true);

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
                        ht.Add("@id", Convert.ToInt32(row.Cells["diseaseID"].Value.ToString()));


                        crud.DataInsertUpdateDelete("st_deleteDisease", ht, "Data deleted");
                        loadData();


                    }
                    else
                    {
                        DiseaseAdd diseaseAdd = new DiseaseAdd(this);
                        diseaseAdd.btnSave.Enabled = false;
                        if (e.RowIndex != -1 && e.ColumnIndex != -1)
                        {
                            diseaseAdd.roleID = Convert.ToInt32(row.Cells["diseaseID"].Value.ToString());
                            diseaseAdd.disText.Texts = row.Cells["diseaseGV"].Value.ToString();
                        }
                        openFormClass.getForm(diseaseAdd, true);
                    }
                }
            }catch (Exception)
            {
                //mainClass.showMessage(ex.ToString(),false);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            searchData();

        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                searchData();
            }
        }
    }
}
