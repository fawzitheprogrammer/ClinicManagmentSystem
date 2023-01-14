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
using ClinicDB.Forms;

namespace ClinicDB
{
    public partial class SymptomsAdd : Form
    {

        SymptomsForm sym;

        public int symptomsID;

        public SymptomsAdd(SymptomsForm symptoms)
        {
            InitializeComponent();
            sym = symptoms;
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
                ht.Add("@name", disText.Texts);
                ht.Add("@did", Convert.ToInt32(disCombo.SelectedValue.ToString()));


                crud.DataInsertUpdateDelete("st_insertSymptoms", ht, "Data inserted");
                mainClass.resetEnable(mainPanel);
                sym.loadData();
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

          if(mainClass.checkControls(mainPanel).Count > 0)
            {
                mainClass.showMessage("Please fill the blank fields", false);
                mainClass.resetEnable(mainPanel);
            }
            else
            {
                Hashtable ht = new Hashtable();
                ht.Add("@name", disText.Texts);
                ht.Add("@did", Convert.ToInt32(disCombo.SelectedValue.ToString()));
                ht.Add("@id", symptomsID);


                /* ListBox paramList = new ListBox();
                   paramList.Items.Add("@name");
                   paramList.Items.Add("@id");
                   ListBox valueList = new ListBox();
                   valueList.Items.Add(roleText.Texts);
                   valueList.Items.Add(roleID);*/

                string theRecord = disText.Texts + " updated successfully in the system.";
                crud.DataInsertUpdateDelete("st_updateSymptoms", ht, theRecord);
                sym.loadData();
                this.Close();
            }
        }

        private void SymptomsAdd_Load(object sender, EventArgs e)
        {
            try
            {
                CRUD.crud.loadRole("st_getDisease", disCombo, "ID", "Disease");
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
        }
    }
}
