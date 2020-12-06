using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    class Company:Customer
    {
        
        public String Location { get; set; }
        public  String Company_type { get; set; }
        public Company() { }
        public Company( String name, string pass, String address, String con_NO, int status , string loc,string type):base ( name, pass, address, con_NO,status) {
            Location = loc;
            Company_type = type;

        }
    }
}
