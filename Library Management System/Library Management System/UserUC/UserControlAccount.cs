using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.UserUC
{
    public partial class UserControlAccount : UserControl
    {
        //initialize other forms
        private Home UHome = null;
        //initialize the user controls
        private UserControlEditDetails EditDetails;
        private UserControlChangePass ChangePass;
        private Control currentContent; //tracks currently displayed content

        public UserControlAccount()
        {
            InitializeComponent();
            UHome = new Home();
        }

        private void UserControlAccount_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //checks for availability of EditDetails and display if its not present
            if (EditDetails == null)
            {
                EditDetails = new UserControlEditDetails();
            }
            else if (currentContent != EditDetails)
            {
                UHome.panelBody.Controls.Remove(currentContent);
                currentContent = EditDetails;
                UHome.panelBody.Controls.Add(EditDetails);
                EditDetails.Visible = true;
            }
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            //checks for availability of Change Password and display if its not present
            if (ChangePass == null)
            {
                ChangePass = new UserControlChangePass();
            }
            else if (currentContent != ChangePass)
            {
                UHome.panelBody.Controls.Remove(currentContent);
                currentContent = ChangePass;
                UHome.panelBody.Controls.Add(ChangePass);
                ChangePass.Visible = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
