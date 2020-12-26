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
            {
                int id;
                string s = username.Text.ToString();
                bool u = context.Customers.Select(c => c.User_name).ToList().Contains(s);
                if (u)
                {

                    string pas = context.Customers.Where(c => c.User_name == s).Select(d => d.Password).Single();
                    if (pas == password.Text.ToString())
                    {
                        id = context.Customers.Where(c => c.User_name == s).Select(d => d.id).Single();
                        Customerpage g = new Customerpage(id);
                        g.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("incorrect password");
                }
                else
                    MessageBox.Show("Incorrect Username  or  Username not found");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Resetpass s = new Resetpass();
                s.ShowDialog();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
