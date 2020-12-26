using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Project.Model.Order;

namespace Project.Model
{
    public partial class Orders_Detiles : Form
    {
        supermarketContext context = new supermarketContext();
        List<Customer> l;
        List<Order> O;
        public Orders_Detiles()
        {
            InitializeComponent();

            var x = context.Orders.Select(f => f.id).ToList();
            listBox1.DataSource = x;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Orders_Detiles_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBox1.SelectedValue.ToString());
            
            var x = context.Transaction_items.Where(d => d.order.id == id).
                                           Select(f => new { f.Quintity, f.product.price }).ToList();

            float totalprice = 0;
            for (int i = 0; i < x.Count; i++)
            {
                
                totalprice += x[i].Quintity * x[i].price;

            }

           
            O = context.Orders.Select(g => g).ToList();

            ordId.Text = id.ToString();
            l = context.Customers.Select(f => f).ToList();
            
            

            foreach (Order n in O)
            {
                if (n.id == id) {
                    int Cid = n.ord_cus.id;
                    foreach (Customer s in l)
                    {
                        if (s.id == Cid)
                            cusname.Text = s.User_name;
                    }

                    Date.Text = n.Date1.ToString();
                    Status.Text = ((Order_Status)n.status).ToString();
                    Totcost.Text = totalprice.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = context.Orders.Where(d => d.id == Convert.ToInt32(listBox1.SelectedValue.ToString())).Select(g => g.id).Single();
            showOrderDetails s = new showOrderDetails(id);
            s.Show();
        }
    }
}
