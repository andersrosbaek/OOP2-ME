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
        public int Price { set; get; }
        public Color CarColor { set; get; }
        public enum Color { Purple, Pink, Orange, Turquoise };
    }
}
