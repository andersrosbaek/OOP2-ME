using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Vehicle
    {
        public string Model { set; get; }
        public double Price { set; get; }
        public string Color { set; get; }

       /* public Color CarColor { set; get; }
        public enum Color { Purple, Pink, Orange, Turquoise };*/

        public Vehicle(string model, string color, double price)
        {
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }
    }
}
