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
        private List<PrivateCustomer> privateCustomers  = new List<PrivateCustomer>();
        private List<BusinessCustomer> businessCustomers = new List<BusinessCustomer>();

        private List<Car> cars = new List<Car>();
        private List<Truck> trucks  = new List<Truck>();

        private List<Leasing> leaseContracts = new List<Leasing>();

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

        public void registerPrivateCustomer(string address, int phone, string name, DateTime age, string sex)
        {
            privateCustomers.Add(new PrivateCustomer(address, phone, name, age, sex));
        }

        public void registerBusinessCustomer(string address, int phone, int seNumber, string contactPerson, int fax, string companyName)
        {
            businessCustomers.Add(new BusinessCustomer(address, phone, seNumber, contactPerson, fax, companyName));
        }

        public List<PrivateCustomer> getPrivateCustomers()
        {
            return privateCustomers;
        }

        public List<BusinessCustomer> getBusinessCustomers()
        {
            return businessCustomers;
        }

        public List<Car> getCars()
        {
            return cars;
        }

        public List<Truck> getTrucks()
        {
            return trucks;
        }
    }
}
