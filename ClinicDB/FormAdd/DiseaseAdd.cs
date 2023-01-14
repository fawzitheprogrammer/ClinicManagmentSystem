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
    public partial class DiseaseAdd : Form
    {

        ClinicDB.DiseasesForm dis;

        public int roleID;

        public DiseaseAdd(ClinicDB.DiseasesForm diseas)
        {
            InitializeComponent();
            dis = diseas;
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

                crud.DataInsertUpdateDelete("st_insertDisease", ht, "Data inserted");
                mainClass.resetEnable(mainPanel);
                dis.loadData();
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add("@name", disText.Texts);
            ht.Add("@id", roleID);

            /*   ListBox paramList = new ListBox();
               paramList.Items.Add("@name");
               paramList.Items.Add("@id");
               ListBox valueList = new ListBox();
               valueList.Items.Add(roleText.Texts);
               valueList.Items.Add(roleID);*/

            string theRecord = disText.Texts + " updated successfully in the system.";
            crud.DataInsertUpdateDelete("st_updateDisease", ht,theRecord);
            dis.loadData();
            this.Close();
        }
    }
}
