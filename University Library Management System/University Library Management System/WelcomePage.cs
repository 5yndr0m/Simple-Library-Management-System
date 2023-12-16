using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dashboard dashboard = null;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new Dashboard();
            }
            dashboard.Show();
            this.Hide();
        }
    }
}
