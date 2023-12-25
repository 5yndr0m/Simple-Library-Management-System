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

namespace Library_Management_System.UserUC
{
    public partial class UserControlReserve : UserControl
    {
        public UserControlReserve()
        {
            InitializeComponent();
        }
        private string book;

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            book = textBoxCodeB1.Text;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sdila\\Documents\\Visual Studio 2022\\Library Management System\\Library Management System\\DatabaseUsers.mdf\";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string insertCommand = @"UPDATE Books SET Reserved = '1' WHERE BookID = @book"
                    ;

                    using (SqlCommand command = new SqlCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@book", book);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Books reserved successfully!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
