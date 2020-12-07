using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Model
{
    
    class Order : IShoppingBag
    {
        public enum Order_Status { New, inProgerss, Pending,  deliverd }
        public int  id {get;set;}
        public DateTime Date1 { get; set; }
        public float  Tax { get; set; }
        public int status { get; set; }
        public  Customer  ord_cus { get; set; }
        
        public List<Transaction_item> items = new List<Transaction_item>();


        public  Order() { }
       public   Order(float tax ,int Status) {
            
            this.Tax = tax;
            this.status = Status;
            
        }
        [NotMapped]
        public float Final_Cost { get; set; }


        
        public string PrintShoppingBag() {

            string myshoppingBag = "Order ID " + '\t' + id + '\t' + " Status " + '\t' + status + " \t" + " Date " + DateTime.Now + '\n' + '\n';

            myshoppingBag = myshoppingBag + " Customer Name =    " + ord_cus.User_name.ToString() + "\n";
            myshoppingBag = myshoppingBag + " Product Name " + '\t' + "Price " + '\t' + " Quintity" + '\t' + "Total Price" + '\n' + '\n';

            foreach (Transaction_item T in items)
            {

                myshoppingBag = myshoppingBag + T.product.name + '\t' + T.product.price + '\t' + T.Quintity + '\t' + T.CostPerItem + '\n';

            }
            myshoppingBag = myshoppingBag + '\n' + '\n' + "Tax   = " + Tax + '\n' + "Total price " + '\t' + Final_Cost;
            return myshoppingBag;

        }
    }
        

    }


