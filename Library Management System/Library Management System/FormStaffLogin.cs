using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FormStaffLogin : Form
    {
        //initialize other forms
        private FormWelcome Welcome = null;
        private FormStaffControls StaffControls = null;

        public FormStaffLogin()
        {
            InitializeComponent();
        }

        private string Username = "admin";
        private string Password = "admin123";

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (Username == textBoxUsername.Text || Password == textBoxPassword.Text)
            {
                if (StaffControls == null || StaffControls.IsDisposed)
                {
                    StaffControls = new FormStaffControls();
                }
                StaffControls.Show();
                this.Hide();
            }
            else
            {
                // Invalid credentials, display error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (Welcome == null || Welcome.IsDisposed)
            {
                Welcome = new FormWelcome();
            }
            Welcome.Show();
            this.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
