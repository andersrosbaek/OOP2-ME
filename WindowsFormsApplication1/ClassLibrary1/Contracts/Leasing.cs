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
        public Leasing(Customer customer, Vehicle vehicle) : base (customer, vehicle)
        {

        }
    }
}
