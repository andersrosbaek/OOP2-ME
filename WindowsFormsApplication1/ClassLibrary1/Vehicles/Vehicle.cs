using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Vehicles;

namespace Domain
{
    public class Vehicle : IVehicle
    {
        public string Type { set; get; }
        public string Model { set; get; }
        public double Price { set; get; }
        public string Color { set; get; }

       /* public Color CarColor { set; get; }
        public enum Color { Purple, Pink, Orange, Turquoise };*/

        public Vehicle (string type, string model, string color, double price) 
        {
            this.Model = model;
            this.Color = color;
            this.Price = price;
            this.Type = type;
        }

        public override string ToString()
        {
            return Color + " " + Model;
        }
    }
}
