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
        private DateTime EndDate { private set; get; }

        public Leasing(BusinessCustomer customer, Truck vehicle, DateTime endDate) : base (customer, vehicle)
        {
            
        }
    }
}
