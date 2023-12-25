using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.UserUC
{
    public partial class UserControlBrowse : UserControl
    {
        private string search;
        public UserControlBrowse()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string selectCommand = @"SELECT * FROM Books WHERE BookName = @search";

                    using (SqlCommand command = new SqlCommand(selectCommand, connection))
                    {
                        command.Parameters.AddWithValue("@search", search);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            string bookid = reader["BookID"].ToString();
                            string bookName = reader["BookName"].ToString();
                            string author = reader["BookAuthor"].ToString();
                            string isbn = reader["isbn"].ToString();
                            string publisher = reader["Publisher"].ToString();
                            string language = reader["Language"].ToString();
                            string year = reader["PublishYear"].ToString();
                            string availability = reader["Availability"].ToString();

                            MessageBox.Show("Book Name: " + bookName + Environment.NewLine +
                                            "Book ID: " + bookid + Environment.NewLine +
                                            "Author: " + author + Environment.NewLine +
                                            "ISBN: " + isbn + Environment.NewLine +
                                            "Publisher: " + publisher + Environment.NewLine +
                                            "Language: " + language + Environment.NewLine +
                                            "Publish Year: " + year + Environment.NewLine +
                                            "Availability: " + availability + Environment.NewLine);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Book name. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void UserControlBrowse_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Books", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridViewBooks.DataSource = table;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
