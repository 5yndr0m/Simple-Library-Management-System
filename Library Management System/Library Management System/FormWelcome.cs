using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.WelcomePage;

namespace Library_Management_System
{
    public partial class FormWelcome : Form
    {
        //initialize other forms
        private Formlogin LoginForm = null;
        private FormRegistration RegistrationForm = null;
        private FormStaffLogin FormStaffLogin = null;
        //initialize the user controls
        private UserControlTitle Title;
        private Control CurrentContent; //tracks currently displayed content

        public FormWelcome()
        {
            InitializeComponent();
            // set default currentContent
            Title = new UserControlTitle();
            CurrentContent = Title; 
            panelHead.Controls.Add(Title);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //opens new instance of FormLogin
            if (LoginForm == null || LoginForm.IsDisposed)
            {
                LoginForm = new Formlogin();
            }
            LoginForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Dispose();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //opens new instance of FormRegistration
            if (RegistrationForm == null || RegistrationForm.IsDisposed)
            {
                RegistrationForm = new FormRegistration();
            }
            RegistrationForm.Show();
            this.Hide();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //opens new instance of FormBrowse

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            if (FormStaffLogin == null || FormStaffLogin.IsDisposed)
            {
                FormStaffLogin = new FormStaffLogin();
            }
            FormStaffLogin.Show();
            this.Hide();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
