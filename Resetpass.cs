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
    public partial class Resetpass : Form
    {

        supermarketContext context = new supermarketContext();
        public Resetpass()
        {
            InitializeComponent();
        }

        private void Resetpass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = username.Text.ToString();
            String Npass = password.Text.ToString();
            Customer c = context.Customers.Where(d => d.User_name == s).Single();
            c.Password = Npass;
            context.SaveChanges();
            username.Text = "";
            password.Text = "";
            MessageBox.Show("Password Update");
        }
    }
}
