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
    public partial class MakeOrder : Form
    {
        public int Id;
        public int OrdId;
        supermarketContext context = new supermarketContext();
        static List<Transaction_item> trans = new List<Transaction_item>();
        
        public MakeOrder(int id,int ordid)
        {
            InitializeComponent();

            this.Id = id;
            this.OrdId = ordid;
            
            var a = context.Products.Select(d=>  d.name).ToList();
            Products.DataSource = a;
           

        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = Products.SelectedItem.ToString();
            Product p = context.Products.Where(d => d.name == s).Select(e => e).Single();
            int v = (int)numericUpDown1.Value;
            if (v == 0)
            {
                MessageBox.Show("Please select quintity more than 0 ");
            }
            else
            {
               
                Transaction_item T = new Transaction_item(v, p);

                T.order 
                    = context.Orders.Where(d => d.id == OrdId).Select(f => f).Single(); ;
                trans.Add(T);
                
                
                List<string> Tname = new List<string>();
                foreach (Transaction_item n in trans)
                    Tname.Add(n.product.name);

                Selected_Product.DataSource = Tname;
                numericUpDown1.Value = 0;
                context.SaveChanges();
            }
        }

        private void Selected_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = Selected_Product.SelectedItem.ToString();
            foreach (Transaction_item n in trans)
            {
                if (n.product.name == s)
                    numericUpDown1.Value = n.Quintity;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = Selected_Product.SelectedItem.ToString();
            foreach (Transaction_item n in trans)
            {
                if (n.product.name == s)
                    n.Quintity = (int)numericUpDown1.Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = Selected_Product.SelectedItem.ToString();
            foreach (Transaction_item n in trans.ToList())
            {
                if (n.product.name == s)
                { 
                        trans.Remove(n);
                    
                }
            }
            List<string> Tname = new List<string>();
            foreach (Transaction_item n in trans)
                Tname.Add(n.product.name);

            Selected_Product.DataSource = Tname;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Transaction_item n in trans.ToList()) {
                context.Transaction_items.Add(n);
            }
            Order ord = context.Orders.Where(d => d.id == OrdId).Select(f => f).Single();
            ord.Date1 = DateTime.Now;
            Customer s = context.Customers.Where(d => d.id == Id).Select(f => f).Single();
            ord.ord_cus = s;
            ord.items = trans;
            ord.status = (Order.Order_Status)1;
            
            _ = context.SaveChanges();
            ConformOrder conf = new ConformOrder(Id,OrdId);
            conf.Show();
        }
       
    }
}
