using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Sale:Contract
    {
        public Sale(PrivateCustomer customer, Car vehicle, double totalPrice) : base(customer, vehicle, totalPrice)
        {

        }
    }
}
