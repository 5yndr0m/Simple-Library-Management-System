using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Register;
using Library_Management_System.WelcomePage;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Library_Management_System
{
    public partial class FormRegistration : Form
    {
        //initialize other forms
        private Formlogin LoginForm = null;
        private FormWelcome Welcome = null;
        //initialize the user controls
        private UserControlRegistertitle Title;
        private Control CurrentContent; //tracks currently displayed content

        //variables to store user details
        private string name;
        private string username;
        private string email;
        private string password;
        private string contactNumber;
        private string registrationNumber;
        private string faculty;

        //regular expressions 
        Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$");
        Regex conNumRegex = new Regex(@"^[0-9]+$");
        Regex RegNumRegex = new Regex(@"^[0-9]{4}/[A-Z]{3}/[0-9]{2}$");
        Regex EmailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        Regex PassRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");


        public FormRegistration()
        {
            InitializeComponent();
            Title = new UserControlRegistertitle();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //assign inputs into variables
            name = textBoxName.Text;
            username = textBoxUsername.Text;
            email = textBoxEmail.Text;
            password = textBoxPassword.Text;
            contactNumber = textBoxConNumber.Text;
            registrationNumber = textBoxRegistrationNo.Text;
            faculty = comboBoxFaculty.SelectedItem.ToString();

            bool hasErrors = false;

            // Validate each input field
            if (!nameRegex.IsMatch(name))
            {
                MessageBox.Show("Invalid name format. Only letters and spaces allowed.");
                hasErrors = true;
            }

            if (!nameRegex.IsMatch(username))
            {
                MessageBox.Show("Invalid username format. Only letters and spaces allowed.");
                hasErrors = true;
            }

            if (!conNumRegex.IsMatch(contactNumber))
            {
                MessageBox.Show("Invalid contact number format. Only numbers allowed.");
                hasErrors = true;
            }

            if (!RegNumRegex.IsMatch(registrationNumber))
            {
                MessageBox.Show("Invalid registration number format.");
                hasErrors = true;
            }

            if (!EmailRegex.IsMatch(email))
            {
                MessageBox.Show("Invalid email format.");
                hasErrors = true;
            }

            if (!PassRegex.IsMatch(password))
            {
                MessageBox.Show("Invalid password format. Password should contain " +
                    "* at least one Capital letter" +
                    "* at least one number" +
                    "* at least one symbol");
                hasErrors = true;
            }

            if (comboBoxFaculty.SelectedItem.ToString().Equals("")) 
            {
                MessageBox.Show("Please select a faculty.");
                hasErrors = true;
            }

            // If there are no errors, proceed with database insertion
            if (!hasErrors)
            {
                try
                {
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string insertCommand = @"INSERT INTO Users (Name, Username, Password, RegistrationNo, Faculty, Email, ContactNo)
                                       VALUES (@name, @username, @password, @registrationNumber, @faculty, @email, @contactNumber)";

                        using (SqlCommand command = new SqlCommand(insertCommand, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                            command.Parameters.AddWithValue("@faculty", faculty);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@contactNumber", contactNumber);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("User registered successfully!");
                        //opens new instance of FormLogin
                        if (LoginForm == null || LoginForm.IsDisposed)
                        {
                            LoginForm = new Formlogin();
                        }
                        LoginForm.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error registering user: " + ex.Message);
                }
            }
        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            //opens new instance of FormLogin
            if (LoginForm == null || LoginForm.IsDisposed)
            {
                LoginForm = new Formlogin();
            }
            LoginForm.Show();
            this.Hide();
        }
    }
}
