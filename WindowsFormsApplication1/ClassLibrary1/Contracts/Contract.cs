using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Contract
    {
        public Customer Customer { private set; get; }

        public Vehicle Vehicle { private set; get; }

        public DateTime Date { private set; get; }

        public double TotalPrice { private set; get; }

        public Contract(Customer customer, Vehicle vehicle, double totalPrice)
        {
            Customer = customer;
            Vehicle = vehicle;
            Date = DateTime.Today;
            TotalPrice = totalPrice;
        }
    }
}
