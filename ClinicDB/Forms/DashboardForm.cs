using MainClass;
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

namespace ClinicDB.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public void countRecords(string proc,string text,FontAwesome.Sharp.IconButton iconButton)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                mainClass.con.Open();
                iconButton.Text = text + " : " + cmd.ExecuteScalar().ToString();
                mainClass.con.Close();

            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            countRecords("st_countPatient", "Patients", allPatient);
            countRecords("st_countMedicine", "Medicines", allMedicine);
            countRecords("st_countStaffDoctor", "Doctors", allDoctors);
            countRecords("st_countStaffNurse", "Nurses", allNurse);
            countRecords("st_countStaffAdmins", "Admins", allAdmin);
            countRecords("st_countStaffMembers", "Staff Members", allStaffMembers);
            countRecords("st_countDiseases", "Diseases", allDisease);
            //st_countDiseases


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
