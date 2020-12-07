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
    public partial class addnewproduct : Form
    {
        supermarketContext context = new supermarketContext();
        public addnewproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  pp = Convert.ToDouble( pprice.Text);
            string N = pname.Text.ToString();
            int Level = Convert.ToInt32(Ilevel.Text);
            String Descriptin = description.Text.ToString();

            Product p = new Product();
            p.name = N;
            p.price = (float)pp ;
            p.invrntoryLevel = Level;
            p.description = Descriptin;
            context.Products.Add(p);
            context.SaveChanges();

            pprice.Text = "";
            pname.Text = "";
            Ilevel.Text = "";
            description.Text = "";
            MessageBox.Show(" Product added to the list ");

        }
    }
}
