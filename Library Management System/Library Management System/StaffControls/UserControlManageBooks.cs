using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;

namespace Library_Management_System.StaffControls
{
    public partial class UserControlManageBooks : UserControl
    {
        public UserControlManageBooks()
        {
            InitializeComponent();
        }

        //variables to store user details
        private string bookID;
        private string bookName;
        private string Author;
        private string isbn;
        private string language;
        private string publisher;
        private string year;

        Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$");
        Regex isbnRegex = new Regex(@"^[0-9]{13}$");

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bookID = textBoxBookID.Text;
            bookName = textBoxBookName.Text;
            Author = textBoxAuthor.Text;
            isbn = textBoxISBN.Text;
            language = textBoxLanguage.Text;
            publisher = textBoxPublisher.Text;
            year = textBoxYear.Text;

            bool hasErrors1 = false;

            if (!nameRegex.IsMatch(bookID))
            {
                MessageBox.Show("Invalid bookID format. Only letters and spaces allowed.");
                hasErrors1 = true;
            }

            if (!nameRegex.IsMatch(bookName))
            {
                MessageBox.Show("Invalid book name. Only letters and spaces allowed.");
                hasErrors1 = true;
            }

            if (!nameRegex.IsMatch(language))
            {
                MessageBox.Show("Invalid language. Only letters and spaces allowed.");
                hasErrors1 = true;
            }

            if (!hasErrors1)
            {
                try
                {
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string insertCommand = @"INSERT INTO Books (BookID, BookName, BookAuthor, isbn, Publisher, Language, PublishYear)
                                       VALUES (@bookID, @bookName, @Author, @isbn, @language, @publisher, @year)";

                        using (SqlCommand command = new SqlCommand(insertCommand, connection))
                        {
                            command.Parameters.AddWithValue("@bookID", bookID);
                            command.Parameters.AddWithValue("@bookName", bookName);
                            command.Parameters.AddWithValue("@Author", Author);
                            command.Parameters.AddWithValue("@isbn", isbn);
                            command.Parameters.AddWithValue("@language", language);
                            command.Parameters.AddWithValue("@publisher", publisher);
                            command.Parameters.AddWithValue("@year", year);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Book registered successfully!");
                        textBoxBookID.Clear();
                        textBoxBookName.Clear();
                        textBoxAuthor.Clear();
                        textBoxISBN.Clear();
                        textBoxLanguage.Clear();
                        textBoxPublisher.Clear();
                        textBoxYear.Clear();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error registering book: " + ex.Message);
                }
            }
        }

    }
}
