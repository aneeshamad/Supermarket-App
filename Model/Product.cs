using Project.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    class Product
    {

       public  Product() { }
        public  int  id { get; set; }
        public String name { get; set; }
        public  float price { get; set; }
        public  int  invrntoryLevel { get; set; }
        public  string description { get; set; }

        public  List<Transaction_item> Transaction_items = new List<Transaction_item>();

        
    }
}
