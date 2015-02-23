using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class PrivateCustomer:Customer
    {
        public string Name { set; get; }
        public DateTime Age { set; get; }
        public string Sex { set; get; }

        public PrivateCustomer(string address, int phone, string name, DateTime age, string sex)
            : base(address, phone)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public PrivateCustomer() 
        {

        }
    }
}
