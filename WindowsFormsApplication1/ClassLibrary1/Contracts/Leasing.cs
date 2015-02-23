using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Leasing:Contract
    {
        public double MonthlyPrice { private set; get; }

        public Leasing(BusinessCustomer customer, Truck vehicle, double totalPrice, double monthlyPrice) : base (customer, vehicle, totalPrice)
        {
            MonthlyPrice = monthlyPrice;
        }
    }
}
