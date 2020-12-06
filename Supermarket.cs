using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
     
    public partial class supermarket : Form
    {
        
      
        

        public supermarket()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.ShowDialog();
            this.Visible = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supermarket_Load(object sender, EventArgs e)
        {

        }
    }
}
