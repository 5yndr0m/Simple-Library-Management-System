using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.UserUC;

namespace Library_Management_System
{
    public partial class Home : Form
    {
        //initialize other forms
        private FormWelcome Welcome = null;
        //initialize the user controls
        private UserControlAccount Account;
        private UserControlBorrow Borrow;
        private UserControlBrowse Browse;
        private UserControlHome HomeDef;
        private UserControlReserve Reserve;
        private Control currentContent; //tracks currently displayed content

        public string username;
        public string password;

        public Home()
        {
            InitializeComponent();
            HomeDef = new UserControlHome();
            currentContent = HomeDef; //set default currentContent to home
            panelBody.Controls.Add(HomeDef);
        }

        public Home(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            //checks for availability of home and display if its not present
            if (currentContent != HomeDef)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = HomeDef;
                panelBody.Controls.Add(HomeDef);
                HomeDef.Visible = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //checks for availability of Browse and display if its not present
            if (Browse == null)
            {
                Browse = new UserControlBrowse();
            }
            else if (currentContent != Browse)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = Browse;
                panelBody.Controls.Add(Browse);
                Browse.Visible = true;
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            //checks for availability of Browse and display if its not present
            if (Borrow == null)
            {
                Borrow = new UserControlBorrow();
            }
            else if (currentContent != Borrow)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = Borrow;
                panelBody.Controls.Add(Borrow);
                Borrow.Visible = true;
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            //checks for availability of Browse and display if its not present
            if (Reserve == null)
            {
                Reserve = new UserControlReserve();
            }
            else if (currentContent != Reserve)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = Reserve;
                panelBody.Controls.Add(Reserve);
                Reserve.Visible = true;
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            //checks for availability of Browse and display if its not present
            if (Account == null)
            {
                Account = new UserControlAccount();
            }
            else if (currentContent != Account)
            {
                panelBody.Controls.Remove(currentContent);
                currentContent = Account;
                panelBody.Controls.Add(Account);
                Account.Visible = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //opens new instance of FormWelcome
            if (Welcome == null || Welcome.IsDisposed)
            {
                Welcome = new FormWelcome();
            }
            Welcome.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
        }

        private void panelSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            labelUsername.Text = username;
        }
    }
}
