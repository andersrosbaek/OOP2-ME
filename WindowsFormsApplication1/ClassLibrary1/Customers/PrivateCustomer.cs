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
        public DateTime Age { set; get; }
        public string Sex { set; get; }

        public PrivateCustomer(string address, int phone, string name, DateTime age, string sex, bool isVehicleNewsReciever)
            : base(address, phone, name, isVehicleNewsReciever)
        {
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Phone: " + Phone + ", Address" + Address + ", Age: " + Age+", Sex: "+Sex;
        }
    }
}
