using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
    class Single_User :Customer
    {
        public char Sex { get; set; }

        public Single_User() { }
        public  Single_User( String name, string pass, String address, String con_NO, int status , char sex):base( name, pass, address, con_NO, status) { 
            Sex = sex;
        }

    }
}
