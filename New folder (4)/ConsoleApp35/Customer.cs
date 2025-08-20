using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Fullname{ get; set; }
        public string NationalID { get; set; }
        public string Dateofbirth { get; set; }
        
        public List< Account> accounts { get; set; }


        





    }
}
