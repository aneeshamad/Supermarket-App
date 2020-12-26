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
    public partial class Customerpage : Form
    {
        public int id;
        supermarketContext context = new supermarketContext();
        public Customerpage(int Id)
        {
            InitializeComponent();
            this.id = Id;
        }

        private void Customerpage_Load(object sender, EventArgs e)
        {
            cusname.Text = context.Customers.Where(c => c.id == id).Select(d=>d.User_name).Single();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login s = new Login();
            s.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_All_Product d = new View_All_Product();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order d = new Order();
            context.Orders.Add(d);
            context.SaveChanges();
            int ordid= context.Orders.Select(d=>d.id).OrderBy(f=>f).Last();
            
            MakeOrder s = new MakeOrder(id,ordid);
            s.Show();
                
        }
    }
}
