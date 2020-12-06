using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    class Transaction_item
    {
        public int id {get;set;}
        public int Quintity { get; set; }
        public  Product product { get; set; }
        public Order order { get; set; }
        public  Transaction_item() { }
        public Transaction_item( int  Quin , Product P) {
            
            this.Quintity = Quin;
            this.product = P;
        }
        
        public  float  item_tot_price()
        {
            return product.price * Quintity;

        }
        
    }
}
