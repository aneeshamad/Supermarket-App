using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.Model
{
    public partial class Orders_Detiles : Form
    {
        supermarketContext context = new supermarketContext();
        public Orders_Detiles()
        {
            InitializeComponent();
            List<Order> ord = context.Orders.Select(d=>d).ToList();
            String s = "";
            foreach (Order d in ord)
            {
                s = s + d.PrintShoppingBag();
            }
            richTextBox1.Text = s;
        }
        
    }
}
