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
    public partial class allpinding : Form
    {

        supermarketContext context = new supermarketContext(); 
        public allpinding()
        {
            InitializeComponent();
            List<Order> pind = context.Orders.Where(o => o.status == 2).Select(o2 => o2).ToList();
        }

        private void AllPindingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
