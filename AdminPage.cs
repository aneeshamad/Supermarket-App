using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminPage : Form
    {
        
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void viewallord_Click(object sender, EventArgs e)
        {
            Orders_Detiles ord = new Orders_Detiles();
            ord.Show();
        }

        private void viewallp_Click(object sender, EventArgs e)
        {
            allpinding s = new allpinding();
            s.ShowDialog();

        }

        private void addnewproduct_Click(object sender, EventArgs e)
        {
            addnewproduct N = new addnewproduct();
            N.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login n = new Login();
            n.Show();

            this.Close();
        }
    }
}
