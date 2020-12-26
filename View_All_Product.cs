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
    public partial class View_All_Product : Form
    {
        supermarketContext context = new supermarketContext();
        public View_All_Product()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Products.Select(d=> new {d.id ,d.name,d.price }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
