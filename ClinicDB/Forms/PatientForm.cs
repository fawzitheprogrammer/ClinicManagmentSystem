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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(ID);
            listBox.Items.Add(patientCol);
            listBox.Items.Add(fatherCol);
            listBox.Items.Add(TurnNumber);
            listBox.Items.Add(appointmentDateCol);
            listBox.Items.Add(phoneCol);
            listBox.Items.Add(ageCol);
            listBox.Items.Add(doctorCol);
            listBox.Items.Add(DoctorIDCol);
            listBox.Items.Add(StatusCol);


            CRUD.crud.loadData("st_getPatientReg", patientDG, listBox);
        }

        public  void searchData()
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
                    listBox.Items.Add(patientCol);
                    listBox.Items.Add(fatherCol);
                    listBox.Items.Add(TurnNumber);
                    listBox.Items.Add(appointmentDateCol);
                    listBox.Items.Add(phoneCol);
                    listBox.Items.Add(ageCol);
                    listBox.Items.Add(doctorCol);
                    listBox.Items.Add(StatusCol);
                    listBox.Items.Add(DoctorIDCol);
                    CRUD.crud.searchData("st_searchPatient", patientDG, listBox, search.Text);
                   
                }
            }
            catch (Exception)
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PatientAdd staff = new PatientAdd(this);
            staff.update.Enabled = false;
            openFormClass.getForm(staff, true);
        }

      
        private void StaffMemeberForm_Load(object sender, EventArgs e)
        {

            loadData();
            // Default sort direction of users datagridview
            //patientDG.Sort(patientDG.Columns[1], ListSortDirection.Ascending);
            //this.ID.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchData();
            }
        }

        private void patientDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = patientDG.Rows[e.RowIndex];

                if (row.Index != -1)
                {

                    if (patientDG.Columns[e.ColumnIndex].Name == "delete")

                    {

                        Hashtable ht = new Hashtable();
                        ht.Add("@id", Convert.ToInt32(row.Cells["ID"].Value.ToString()));


                        crud.DataInsertUpdateDelete("st_deletePatientReg", ht, "Data deleted");
                        loadData();


                    }
                    else
                    {
                        PatientAdd patient = new PatientAdd(this);
                        patient.save.Enabled = false;
                        if (e.RowIndex != -1 && e.ColumnIndex != -1)
                        {
                            patient.lblID.Text = row.Cells["ID"].Value.ToString();
                            patient.patientNameTxt.Texts = row.Cells["patientCol"].Value.ToString();
                            patient.fatherTxt.Texts = row.Cells["fatherCol"].Value.ToString();
                            patient.ageTxt.Texts = row.Cells["ageCol"].Value.ToString();
                            patient.phoneTxt.Texts = row.Cells["phoneCol"].Value.ToString();
                            patient.appointmentDatePicker.Value = Convert.ToDateTime(row.Cells["appointmentDateCol"].Value.ToString());
                            //patient.appointmentForCombo.Text = row.Cells["AppointmentFCol"].Value.ToString();
                            patient.consultedTxt.Text = row.Cells["doctorCol"].Value.ToString();
                            patient.doctorID.Text = row.Cells["DoctorIDCol"].Value.ToString();
                            patient.statusTxt.Text = row.Cells["StatusCol"].Value.ToString();
                            


                        }
                        openFormClass.getForm(patient, true);
                    }
                }
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(),false);
            }
        }
    }
}
