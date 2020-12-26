using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{  
    public partial class ConformOrder : Form
    { 
        supermarketContext context = new supermarketContext();
        int cosId;
        int  ordId;
        public ConformOrder(int cosId, int ordId)
        {
            InitializeComponent();
            this.cosId = cosId;
            this.ordId = ordId;


          List<Transaction_item> s=  context.Transaction_items.Where(d => d.order.id == ordId).Select(F => F).ToList();


            List<newTable> l = new List<newTable>();
            var x = context.Transaction_items.Where(d => d.order.id == ordId).
                                              Select(f => new { f.product.name, f.Quintity, f.product.price, f.CostPerItem }).ToList();
            float totalprice = 0;
            for(int i=0;i<x.Count;i++)
            {
                l.Add(new newTable { id = i,name = x[i].name , quintity=x[i].Quintity,total = x[i].Quintity*x[i].price });
                totalprice += x[i].Quintity * x[i].price;
                context.Products.Where(p => p.name == x[i].name).Select(c => c ).Single().invrntoryLevel =
                                                       context.Products.Where(p => p.name == x[i].name).Select(c => c).Single().invrntoryLevel - x[i].Quintity;
                
            }
            dataGridView1.DataSource = l;
           
            context.Orders.Where(d => d.id == ordId).
                                              Select(f => f).Single().status = (Order.Order_Status)2;
            context.Orders.Where(d => d.id == ordId).
                                             Select(f => f).Single().Final_Cost = totalprice;
            context.SaveChanges();
            label2.Text = context.Orders.Where(d => d.id == ordId).
                                             Select(f => f.Final_Cost).Single().ToString();
            
        }
        
        private void ConformOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Order.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
    public class newTable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quintity { get; set; }
        public float total { get; set; }
    }
}
