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
        private Control currentContent;

        public FormStaffControls()
        {
            InitializeComponent();
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

    }
}
