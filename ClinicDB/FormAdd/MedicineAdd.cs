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
    public partial class MedicineAdd : Form
    {

        ClinicDB.MedicineForm meds;

        public int roleID;

        public MedicineAdd(ClinicDB.MedicineForm med)
        {
            InitializeComponent();
            meds = med;
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
                ht.Add("@medName", medTxt.Texts);
                ht.Add("@medCom", comTxt.Texts);
                ht.Add("@medType", type.SelectedItem.ToString());

                crud.DataInsertUpdateDelete("st_insertMed", ht, "Data inserted");
                mainClass.resetEnable(mainPanel);
                meds.loadData();
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add("@medName", medTxt.Texts);
            ht.Add("@medCom", comTxt.Texts);
            ht.Add("@medType", type.SelectedItem.ToString());

            /*   ListBox paramList = new ListBox();
               paramList.Items.Add("@name");
               paramList.Items.Add("@id");
               ListBox valueList = new ListBox();
               valueList.Items.Add(roleText.Texts);
               valueList.Items.Add(roleID);*/

            string theRecord = medTxt.Texts + " updated successfully in the system.";
            crud.DataInsertUpdateDelete("st_updateRoles", ht,theRecord);
            meds.loadData();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
