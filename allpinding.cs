using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Project.Model.Order;

namespace Project
{
    public partial class allpinding : Form
    {
        List<int> ord= new List<int>();
        supermarketContext context = new supermarketContext(); 
        public allpinding()
        {
            InitializeComponent();
             ord = context.Orders.Where(d => d.status == (Order_Status)2).Select(o => o.id).ToList();
            var listt = context.Orders.Where(d => d.status == (Order_Status)2).Select(o => new { o.id,o.ord_cus.User_name}).ToList();
            AllPindingOrders.DataSource = listt;

        }

        private void AllPindingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int n in ord)
            {
                context.Orders.Where(d => d.id == n).ToList().ForEach(x => x.status = (Order_Status)3);
            }
            context.SaveChanges();
            AllPindingOrders.DataSource = null;
        }
    }
}
