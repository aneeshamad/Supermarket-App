using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    
    class Order : IShoppingBag
    {
        public enum Order_Status { New, inProgerss, Closed, Modified, deliverd ,Pending}
        public int  id {get;set;}
        public float  Tax { get; set; }
        public Order_Status status { get; set; }
        public  Customer  ord_cus { get; set; }
        
        public List<Transaction_item> items = new List<Transaction_item>();


        public  Order() { }
       public   Order(float tax ,int Status) {
            
            this.Tax = tax;
            this.status = (Order_Status)Status;
            
        }
        public bool add_item(Transaction_item item)
        {

            items.Add(item);
            return true;

        }
        public bool delete_item(Transaction_item item) {
            
            items.Remove(item);
            return true;
            
        }
        public bool update_item(Transaction_item item, int new_quintity)
        {
                foreach (Transaction_item a in items)
                {
                if (a == item)
                {
                    a.Quintity = new_quintity;
                    return true;
                }
                else return false;
                }
            return true;
        }

        public  float  get_order_price()
        {
            float sum = 0;
            foreach (Transaction_item t in items)
            {
                    sum = sum + (t.product.price * t.Quintity);    
            }
            if (Tax == 0)
                return sum;
            else
                return sum +( sum * Tax);
        }

        public string PrintShoppingBag()
        {


            string myshoppingBag = "Order ID "+'\t' + id +'\t'+ " Status "+'\t'+ status+ " \t"+" Date "+ DateTime.Now +'\n'+'\n';

            myshoppingBag = myshoppingBag + " Customer Name =    " + ord_cus.User_name.ToString()+"\n";
            myshoppingBag = myshoppingBag + " Product Name " +'\t' + "Price "+'\t'+ " Quintity"+'\t'+ "Total Price"+'\n'+'\n';

            foreach (Transaction_item T in items)
            {

                myshoppingBag = myshoppingBag + T.product.name + '\t' + T.product.price + '\t' + T.Quintity + '\t' + T.item_tot_price() + '\n' ;
                
            }
            myshoppingBag = myshoppingBag +'\n'+'\n'+ "Tax   = " + Tax + '\n' + "Total price " + '\t' + get_order_price();
            return myshoppingBag;

        }

    }

}

