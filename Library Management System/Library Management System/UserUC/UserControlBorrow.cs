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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Library_Management_System.UserUC
{
    public partial class UserControlBorrow : UserControl
    {
        public UserControlBorrow()
        {
            InitializeComponent();
        }

        private string username;
        private string bookid1;
        private string bookid2;
        private string borrowDate;
        private string ReturnDate;
        private char borrowed = '1';

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            bookid1 = textBoxCodeB1.Text;
            bookid2 = textBoxCodeB2.Text;
            borrowDate = textBoxbdate.Text;
            ReturnDate = textBoxrdate.Text;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string insertCommand = @"INSERT INTO Borrow (RegistrationNo, BookID1, BookID2, BorrowDate, ReturnDate, Borrow)
                                       VALUES (@username, @bookid1, @bookid2, @borrowDate, @ReturnDate, @borrowed)"
                    ;

                    using (SqlCommand command = new SqlCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@bookid1", bookid1);
                        command.Parameters.AddWithValue("@bookid2", bookid2);
                        command.Parameters.AddWithValue("@borrowDate", borrowDate);
                        command.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                        command.Parameters.AddWithValue("@borrowed", borrowed);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Books borrowed successfully!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error borrowing books: " + ex.Message);
            }
        }
    }
}
