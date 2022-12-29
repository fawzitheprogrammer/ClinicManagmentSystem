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
    public partial class MedicineForm : Form
    {
       
        public MedicineForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(ID);
            listBox.Items.Add(medicine);
            listBox.Items.Add(company);
            listBox.Items.Add(type);

            CRUD.crud.loadData("st_getMed", medDg, listBox);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

            MedicineAdd medAdd = new MedicineAdd(this);
            medAdd.rjButton1.Enabled = false;
            openFormClass.getForm(medAdd, true);

        }

        private void user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void user_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = medDg.Rows[e.RowIndex];

                if (row.Index != -1)
                {

                    if (medDg.Columns[e.ColumnIndex].Name == "delete")

                    {

                        Hashtable ht = new Hashtable();
                        ht.Add("@id", Convert.ToInt32(row.Cells["ID"].Value.ToString()));


                        crud.DataInsertUpdateDelete("st_deleteMed", ht, "Data deleted");
                        loadData();


                    }
                    else
                    {
                        MedicineAdd medAdd = new MedicineAdd(this);
                        medAdd.btnSave.Enabled = false;
                        if (e.RowIndex != -1 && e.ColumnIndex != -1)
                        {
                            medAdd.roleID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                            medAdd.medTxt.Texts = row.Cells["medicine"].Value.ToString();
                            medAdd.comTxt.Texts = row.Cells["company"].Value.ToString();
                            medAdd.type.Text = row.Cells["type"].Value.ToString();                        }
                            openFormClass.getForm(medAdd, true);
                    }
                }
            }catch (Exception)
            {
                //mainClass.showMessage(ex.ToString(),false);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            if (search.Text == "" || search.Text == null)
            {
                loadData();
            }
            else
            {
                ListBox listBox = new ListBox();
                listBox.Items.Add(ID);
                listBox.Items.Add(medicine);
                listBox.Items.Add(company);
                listBox.Items.Add(type);
                CRUD.crud.searchData("st_searchMed", medDg,listBox, search.Text);
            }

        }
    }
}
