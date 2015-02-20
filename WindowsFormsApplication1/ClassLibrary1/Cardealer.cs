using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Cardealer
    {
        private List<Private> privateCustomers = new List<Private>();
        private List<Business> businessCustomers = new List<Business>();
        private List<Car> cars = new List<Car>();
        private List<Truck> trucks = new List<Truck>();

        private static Cardealer instance;

        public static Cardealer getInstance()
        {
            if(instance == null)
            {
                instance = new Cardealer();
            }

            return instance;
        }

        public void registerVehicle(string type, string model, string color, double price)
        { 
            if(type == "car")
            {
                cars.Add(new Car(model, color, price));
            }
            else if (type == "truck")
            {
                trucks.Add(new Truck(model, color, price));
            }
        }

        public void registerPrivate()
        {

        }

        public void registeBusiness()
        {

        }
    }
}
