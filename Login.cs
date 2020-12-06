using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{ 
    public partial class Login : Form
    {
        supermarketContext context = new supermarketContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Add_new_customer c1 = new Add_new_customer();
            c1.Show();

        }

        private void log_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                AdminPage p = new AdminPage();
                p.Show();
                Close();
            }
            else
                MessageBox.Show("Incorrect User Name or Password ");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Resetpass s = new Resetpass();
                s.ShowDialog();
            
        }
    }
}
