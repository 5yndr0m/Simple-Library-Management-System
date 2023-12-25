using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IdentityModel.Selectors;
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
        private Formlogin logindata = null;
        //initialize the user controls
        private UserControlEditDetails EditDetails;
        private UserControlChangePass ChangePass;
        private Control currentContent; //tracks currently displayed content

        private string user_id;
        private string user_password;
        private string name;
        private string username;
        private string email;
        private string contactNumber;
        private string registrationNumber;
        private string faculty;
        private string borrow;
        private string duedate;
        private string password;
        public UserControlAccount()
        {
            InitializeComponent();
            UHome = new Home();
            logindata = new Formlogin();
        }

        public UserControlAccount(string username, string password)
        {
            InitializeComponent();
            UHome = new Home();
            logindata = new Formlogin();
            user_id = this.username;
            user_password = this.password;
        }

        private void UserControlAccount_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string selectCommand = @"SELECT * FROM Users WHERE Username = @user_id AND Password = @user_password";

                    using (SqlCommand command = new SqlCommand(selectCommand, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", user_id ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@user_password", user_password ?? (object)DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                name = reader["Name"].ToString();
                                username = reader["Username"].ToString();
                                email = reader["Email"].ToString();
                                contactNumber = reader["ContactNo"].ToString();
                                registrationNumber = reader["RegistrationNo"].ToString();
                                faculty = reader["Faculty"].ToString();
                            }
                        command.Parameters.AddWithValue("@registrationNumber", registrationNumber ?? (object)DBNull.Value);

                        while (reader.Read())
                        {
                            borrow = reader["Borrow"].ToString();
                            duedate = reader["ReturnDate"].ToString();
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error checking credentials: " + ex.Message);
            }
            labelPlaceHoldName.Text = name;
            labelPlaceHoldUName.Text = username;
            labelPlaceHoldRegNo.Text = registrationNumber;
            labelPlaceHoldFaculty.Text = faculty;
            labelPlaceHoldEmail.Text = email;
            labelPlaceHoldConNo.Text = contactNumber;
            labelPlaceHoldBStatus.Text = borrow;
            labelPlaceHoldDue.Text = duedate;
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

    }
}
