using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Vehicles
{
    interface IVehicle
    {
        string Type  { set; get; }
        string Model { set; get; }
        double Price { set; get; }
        string Color { set; get; }
    }
}
