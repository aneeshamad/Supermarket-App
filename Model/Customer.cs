using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    
    class Customer
    {
        public  enum customer_Status { New, Active, Blocked }
        public int id { get; set; }
        public String User_name { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String contact_NO { get; set; }
        public customer_Status status { get; set; }
        public List<Order> orders = new List<Order>();

          public Customer() { }
          public Customer (String name ,string pass ,String address,String con_NO, customer_Status sta ){
            
            User_name = name;
            Password = pass;
            Address = address;
            contact_NO = con_NO;
            status = sta;
        }
        


    }
}
