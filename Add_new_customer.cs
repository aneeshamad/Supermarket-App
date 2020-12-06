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
    public partial class Add_new_customer : Form
    {
        supermarketContext context = new supermarketContext();
         
        public Add_new_customer()
        {
            InitializeComponent();

        }

        private void Add_new_customer_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = name.Text.ToString();
            String Pass = pass.Text.ToString();
            string Address = address.Text.ToString();
            String contact = NO.Text.ToString();
            int Status =status.SelectedIndex;
            name.Text = "";
            pass.Text = "";
            address.Text = "";
            NO.Text = "";
            if (single.Checked)
            {
                
                if (mail.Checked)
                {
                    Single_User m = new Single_User(Name, Pass, Address, contact, Status, 'M');
                    context.Single_Users.Add(m);
                }
                else
                {
                    Single_User f = new Single_User(Name, Pass, Address, contact, Status, 'F');
                    context.Single_Users.Add(f);

                }

            }
            else
            {
               
                String t = type.Text.ToString();
                string loc = location.Text.ToString();
                Company c = new Company(Name, Pass, Address, contact, Status, loc, t);
                context.Companys.Add(c);
            }
            context.SaveChanges();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void single_CheckedChanged(object sender, EventArgs e)
        {
            if (single.Checked == true)
            {
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void company_CheckedChanged(object sender, EventArgs e)
        {
            if (company.Checked == true)
            {
                panel3.Visible = true;
                panel2.Visible = false;
            }
        }
    }
}
