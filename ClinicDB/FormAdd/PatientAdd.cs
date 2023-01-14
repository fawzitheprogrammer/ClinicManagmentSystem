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
    public partial class PatientAdd : Form
    {

        PatientForm patients;

        public int usersID;


        public PatientAdd(PatientForm patient)
        {
            InitializeComponent();
            patients = patient;
        }


        private bool getPatientRecord(string phone)
        {
            bool isChecked = false;


            try
            {


                SqlCommand cmd = new SqlCommand("st_checkPatientRegistrationExist", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                mainClass.con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    isChecked = true;
                    while (dataReader.Read())
                    {
                        patientNameTxt.Texts = dataReader["Patient"].ToString();
                        fatherTxt.Texts = dataReader["Guardian"].ToString();
                        ageTxt.Texts = dataReader["Age"].ToString();
                        lastAppointmentDatePicker.Value = Convert.ToDateTime(dataReader["Last Appointment"].ToString());
                        consultedTxt.Texts = dataReader["Doctor"].ToString();
                        statusTxt.Texts = dataReader["Status"].ToString();


                    }
                }
                else
                {
                    isChecked = false;
                }

                mainClass.con.Close();


            }
            catch (Exception e)
            {
                mainClass.con.Close();
                mainClass.showMessage(e.ToString(), false);
            }
            return isChecked;

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (mainClass.checkControls(panel1).Count > 0)
            {
                mainClass.showMessage("Please fill out all fields.", false);
            }
            else
            {
                // Inserting Patient
                Hashtable ht = new Hashtable();
                ht.Add("@name", patientNameTxt.Texts);
                ht.Add("@guardian", fatherTxt.Texts);
                ht.Add("@phone", phoneTxt.Texts);
                ht.Add("@age", Convert.ToInt32(ageTxt.Texts));

                CRUD.crud.DataInsertUpdateDelete("st_insertPatientReg", ht, "");

                // Inserting Appointment 
                int patient = Convert.ToInt32(CRUD.crud.getLastID("st_getLastPatientID"));
                Hashtable htA = new Hashtable();
                htA.Add("@date", appointmentDatePicker.Value);
                htA.Add("@doctorID", Convert.ToInt32(appointmentForCombo.SelectedValue.ToString()));
                htA.Add("@patientID", patient);
                htA.Add("@statusID", 0);
                htA.Add("@day", appointmentDatePicker.Value.Day);
                htA.Add("@month", appointmentDatePicker.Value.Month);
                htA.Add("@year", appointmentDatePicker.Value.Year);
                CRUD.crud.DataInsertUpdateDelete("st_insertAppointment", htA, "Data inserted");
                patients.loadData();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffMemeberAdd_Load(object sender, EventArgs e)
        {
           

            try
            {
                CRUD.crud.loadRole("st_getDoctors", appointmentForCombo, "Doctor ID", "Doctor");
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if(phoneTxt.Texts != "")
            {
                if (getPatientRecord(phoneTxt.Texts))
                {
                    
                }
                else
                {
                }
            }
        }

         int getStatus()
        {
            int status = 0;
            if (statusTxt.Texts== "Not Consulated")
            {
                status = 0;
            }
            else if(statusTxt.Texts == "Consulated")
            {
                status = 1;
            }
            else if(statusTxt.Texts == "Completed")
            {
                status = 2;
            }
            else
            {

            }

            return status;
        }

        private void update_Click(object sender, EventArgs e)
        {

            try
            {
                if (mainClass.checkControls(panel1).Count > 0)
                {
                    mainClass.showMessage("Please fill out all fields.", false);
                }
                else
                {
                    // Inserting Patient
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", patientNameTxt.Texts);
                    ht.Add("@guardian", fatherTxt.Texts);
                    ht.Add("@phone", phoneTxt.Texts);
                    ht.Add("@age", Convert.ToInt32(ageTxt.Texts));
                    ht.Add("@id", Convert.ToInt32(lblID.Text));
                    CRUD.crud.DataInsertUpdateDelete("st_updatePatientReg", ht, "");

                    // Inserting Appointment 
                    int patient = Convert.ToInt32(CRUD.crud.getLastID("st_getLastPatientID"));
                    Hashtable htA = new Hashtable();
                    htA.Add("@date", appointmentDatePicker.Value);
                    htA.Add("@doctorID", Convert.ToInt32(appointmentForCombo.SelectedValue.ToString()));
                    htA.Add("@patientID", patient);
                    htA.Add("@statusID", getStatus());
                    htA.Add("@id", Convert.ToInt32(lblID.Text));
                    CRUD.crud.DataInsertUpdateDelete("st_updatePatientAppointment", htA, "Data Updated");
                    patients.loadData();

                }
            }
            catch(Exception ex)
            {
                mainClass.showMessage(ex.ToString(),false);
            }
        }

        private void doctorID_Click(object sender, EventArgs e)
        {

        }

        private void appointmentID_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}

