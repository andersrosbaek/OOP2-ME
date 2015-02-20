using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Customer
    {
        public string Address { set; get; }
        public int Phone { set; get; }

        public Customer(string address, int phone)
        {
            Address = address;
            Phone = phone;
        }
    }
}
