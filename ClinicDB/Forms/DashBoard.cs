using ClinicD.FormAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB.Forms
{
    public partial class mainFormId : Form
    {

        private FontAwesome.Sharp.IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public mainFormId()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(sickbtn.Size.Width-806,sickbtn.Height);
            menuPanel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


           

        }

        // check if form is maxed 
        private void getInfo()
        {
            
        }

        private struct RGBColors
        {
            public static Color active = Color.FromArgb(60,232,109);
            public static Color disable = Color.FromArgb(0, 133, 161);
            public static Color color3 = Color.FromArgb(141, 91, 227);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (FontAwesome.Sharp.IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0,82,94);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //Left border button
                leftBorderBtn.BackColor = Color.White;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.disable;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }


        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            OpenChildForm(dash);
            ActivateButton(sender, Color.White);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            StaffMemeberForm staff = new StaffMemeberForm();
            OpenChildForm(staff);
            ActivateButton(sender, Color.White);
           
        }

        private void disbtn_Click(object sender, EventArgs e)
        {
            PatientForm patient = new PatientForm();
            OpenChildForm(patient);
            ActivateButton(sender, Color.White);

        }

        private void sickbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);


        }

        private void userbtn_Click(object sender, EventArgs e)
        {

            MedicineForm med = new MedicineForm();
            OpenChildForm(med);
            ActivateButton(sender, Color.White);

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           

        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }


        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mainFormId_Resize(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                menuPanel.Width = 353;
                //doc.docDt.DefaultCellStyle.Font = new Font(new FontFamily("Poppins"), 38);
            }
            else
            {
                menuPanel.Width = 253;
                //doc.docDt.DefaultCellStyle.Font = new Font(new FontFamily("Poppins"), 4);

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }

        private void mainFormId_Load(object sender, EventArgs e)
        {
            dashbtn.PerformClick();
        }

        private void sickbtn_Click_1(object sender, EventArgs e)
        {
            SymptomsForm symptoms = new SymptomsForm();
            OpenChildForm(symptoms);
            ActivateButton(sender, Color.White);
        }

        private void phonNum_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            OpenChildForm(roles);
            ActivateButton(sender, Color.White);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            DiseasesForm diseasesForm = new DiseasesForm();
            OpenChildForm(diseasesForm);
            ActivateButton(sender, Color.White);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
     

        }
    }
}