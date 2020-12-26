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
        public Order_Status status { get; set; }
        public  Customer  ord_cus { get; set; }
        
        public List<Transaction_item> items = new List<Transaction_item>();


        public  Order() { }
       public   Order(float tax , Order_Status Status) {
            
            this.Tax = tax;
            this.status = Status;
            
        }
        [NotMapped]
        public float Final_Cost { get; set; }
             
       
        public string PrintShoppingBag( ) {

            return "";

        }
    }
        

    }


