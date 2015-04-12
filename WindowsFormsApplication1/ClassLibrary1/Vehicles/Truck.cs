using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Truck:Vehicle
    {
        public Truck(string type, string model, string color, double price) : base(type, model, color, price)
        { 
        }
    }
}
