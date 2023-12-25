using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.StaffControls
{
    public partial class UserControlManageUsers : UserControl
    {
        private string username;
        private string registrationNumber;
        private string removeID;

        public UserControlManageUsers()
        {
            InitializeComponent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            username = textBoxRemoveUser.Text;
            registrationNumber = textBoxRegno.Text;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                
                    string deleteCommand = @"DELETE FROM Users WHERE Username = @username AND RegistrationNo = @registrationNumber";

                    using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery(); 

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("User Removed.");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or registration number. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error removing user: " + ex.Message);
            }
        }

        private void buttonRemoveBooks_Click(object sender, EventArgs e)
        {
            removeID = textBoxRemoveID.Text;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string deleteCommand = @"DELETE FROM Books WHERE BookID = @removeID";

                    using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@removeID", removeID);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Book Removed.");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Book ID. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error removing user: " + ex.Message);
            }
        }
    }
}
