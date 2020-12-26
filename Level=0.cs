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
    public partial class Level_0 : Form
    {

        supermarketContext context = new supermarketContext();
        public Level_0()
        {
            InitializeComponent();
           
                var x = context.Products.Where(p => p.invrntoryLevel == 0).Select(s => new { s.id, s.name }).ToList();
                dataGridView1.DataSource = x;
            
        }

        private void Level_0_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
