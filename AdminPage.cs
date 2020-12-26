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
    public partial class AdminPage : Form
    {
        supermarketContext context = new supermarketContext();
        List<Order> g;
        List<Customer> c;
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

        private void viewallzero_Click(object sender, EventArgs e)
        { 
            var v = context.Products.Where(p => p.invrntoryLevel == 0).Count();

            if (v == 0)
                MessageBox.Show("No product with inventory level = 0");
            else
            {
                Level_0 s = new Level_0();
                s.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int count = context.Customers.OfType<Company>().Count();
            MessageBox.Show(text: "Number of Companies is " + count);
        }
        List<float> tot = new List<float>();
        private void viewmax_Click(object sender, EventArgs e)
        {
           c = context.Customers.Select(f => f).ToList();
           g= context.Orders.Select(f =>f).ToList();
            for (int i = 0; i < g.Count; i++)
                tot.Add(g[i].Final_Cost);

            float x = tot.Max();
            int Cid=0;
             foreach(Order n in g)
            { 
               if (n.Final_Cost == x)
                   Cid= n.ord_cus.id;
            }

            string cn = c.Where(d => d.id == Cid).Select(f => f.User_name).Single();
            MessageBox.Show("The customer that has the maximum order price is  " + cn + "\n" +
              "with order price = " + x) ;
            
        }
    }
}
