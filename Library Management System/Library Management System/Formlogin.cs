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
using Library_Management_System.Login;
using Library_Management_System.WelcomePage;

namespace Library_Management_System
{
    public partial class Formlogin : Form
    {
        //initialize other forms
        private FormWelcome Welcome = null;
        private FormRegistration RegistrationForm = null;
        private Home FormHome = null;
        //initialize the user controls
        private UserControlTitleLogin Title;
        private Control CurrentContent;//tracks currently displayed content
        //variables to store user details
        private string username;
        private string password;
        public Formlogin()
        {
            InitializeComponent();
            // set default currentContent
            Title = new UserControlTitleLogin();
            CurrentContent = Title;
            panelHead.Controls.Add(Title);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //opens new instance of FormWelcome
            if (Welcome == null || Welcome.IsDisposed)
            {
                Welcome = new FormWelcome();
            }
            Welcome.Show();
            this.Hide();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string selectCommand = @"SELECT * FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlCommand command = new SqlCommand(selectCommand, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Credentials match, redirect to home form
                            reader.Close();
                            Home FormHome= new Home();
                            FormHome.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            // Invalid credentials, display error message
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error checking credentials: " + ex.Message);
            }


        }
    }
}
