using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.StaffControls;
using Library_Management_System.UserUC;

namespace Library_Management_System
{
    public partial class FormStaffControls : Form
    {
        //initialize other forms
        private FormWelcome Welcome = null;
        //initialize the user controls
        private UserControlManageBooks UserControlManageBooks = null;
        private UserControlManageUsers UserControlManageUsers = null;
        private UserControlStaffHome UserControlStaffHome = null;
        private Control currentContent;

        public FormStaffControls()
        {
            InitializeComponent();
            UserControlStaffHome = new UserControlStaffHome();
            currentContent = UserControlStaffHome;
            panelBody.Controls.Add(UserControlStaffHome);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (Welcome == null || Welcome.IsDisposed)
            {
                Welcome = new FormWelcome();
            }
            Welcome.Show();
            this.Hide();
        }

        private void buttonBookManagement_Click(object sender, EventArgs e)
        {
            if (UserControlManageBooks == null)
            {
                UserControlManageBooks = new UserControlManageBooks();
            }
            else if (currentContent != UserControlManageBooks)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = UserControlManageBooks;
                panelBody.Controls.Add(UserControlManageBooks);
                UserControlManageBooks.Visible = true;
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (UserControlManageUsers == null)
            {
                UserControlManageUsers = new UserControlManageUsers();
            }
            else if (currentContent != UserControlManageUsers)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = UserControlManageUsers;
                panelBody.Controls.Add(UserControlManageUsers);
                UserControlManageUsers.Visible = true;
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (currentContent != UserControlStaffHome)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = UserControlStaffHome;
                panelBody.Controls.Add(UserControlStaffHome);
                UserControlStaffHome.Visible = true;
            }
        }
    }
}
