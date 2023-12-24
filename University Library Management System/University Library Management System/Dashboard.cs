using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Library_Management_System.UserControlStaff;

namespace University_Library_Management_System
{
    public partial class Dashboard : Form
    {
        //initialize the user controls
        private Account account;
        private AddBooks books;
        private AddUsers Users;
        private Analysis analysis;
        private Catalogue catalogue;
        private EditBooks editBooks;   
        private EditUsers editUsers;
        private FineCalculator fineCalculator;
        private Home home;
        private RemoveBooks removedBooks;
        private RemoveUser removedUsers;
        private UserManagement userManagement;
        private Control currentContent; //tracks currently displayed content

        public Dashboard()
        {
            InitializeComponent();
            home = new Home();
            currentContent = home; //set default currentContent to home
            panelContent.Controls.Add(home);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //checks for availability of home and display if its not present
            if (currentContent != home)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = home;
                panelContent.Controls.Add(home); 
                home.Visible = true;
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            //checks for availability of Catalog and display if its not present
            if (catalogue == null)
            {
                catalogue = new Catalogue();
            }
            else if (currentContent != catalogue)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = catalogue;
                panelContent.Controls.Add(catalogue);
                catalogue.Visible = true;
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            //checks for availability of Account and display if its not present
            if (account == null)
            {
                account = new Account();
            }
            else if (currentContent != account)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = account;
                panelContent.Controls.Add(account);
                account.Visible = true;
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            //checks for availability of User Management and display if its not present
            if (userManagement == null)
            {
                userManagement = new UserManagement();
            }
            else if (currentContent != catalogue)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = userManagement;
                panelContent.Controls.Add(userManagement);
                userManagement.Visible = true;
            }
        }

        private void buttonCalFine_Click(object sender, EventArgs e)
        {
            //checks for availability of Fine Calculator and display if its not present
            if (fineCalculator == null)
            {
                fineCalculator = new FineCalculator();
            }
            else if (currentContent != catalogue)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = fineCalculator;
                panelContent.Controls.Add(fineCalculator);
                fineCalculator.Visible = true;
            }
        }

        private void buttonAnalysis_Click(object sender, EventArgs e)
        {
            //checks for availability of Analysis and display if its not present
            if (analysis == null)
            {
                analysis = new Analysis();
            }
            else if (currentContent != catalogue)
            {
                panelContent.Controls.Remove(currentContent);
                currentContent = analysis;
                panelContent.Controls.Add(analysis);
                analysis.Visible = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
