using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Vehicles;

namespace Domain
{
    public class Cardealer
    {
        private List<PrivateCustomer> privateCustomers  = new List<PrivateCustomer>();
        private List<BusinessCustomer> businessCustomers = new List<BusinessCustomer>();

        private List<Car> cars = new List<Car>();
        private List<Truck> trucks  = new List<Truck>();

        private List<Sale> salesContracts = new List<Sale>();
        private List<Leasing> leasingContracts = new List<Leasing>();

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
            IVehicle vehicle = null;

            if(type == "car")
            {
                Car car = new Car(type, model, color, price);
                vehicle = car;
                cars.Add(car);
            }
            else if (type == "truck")
            {
                Truck truck = new Truck(type, model, color, price);
                vehicle = truck;
                trucks.Add(truck);
            }

            if (vehicle != null)
                Announcer.getInstance().AnnounceNewVehicle(vehicle);
        }

        public void registerPrivateCustomer(string address, int phone, string name, DateTime age, string sex, bool isVehicleNewsReciever)
        {
            PrivateCustomer costumer = new PrivateCustomer(address, phone, name, age, sex , isVehicleNewsReciever);

            // Check whether to register and Register costumer as a Vehicle news reciever
            if (isVehicleNewsReciever)
                Announcer.getInstance().RegisterVehicleNewsReciever(new Announcer.VehicleNewsHandler(costumer.PresentAnnouncement));

            privateCustomers.Add(costumer);
        }

        public void registerBusinessCustomer(string address, int phone, int seNumber, string contactPerson, int fax, string companyName, bool isVehicleNewsReciever)
        {
            BusinessCustomer customer = new BusinessCustomer(address, phone, seNumber, contactPerson, fax, companyName, isVehicleNewsReciever);

            // Check whether to register and Register costumer as a Vehicle news reciever
            if(isVehicleNewsReciever)
                Announcer.getInstance().RegisterVehicleNewsReciever(new Announcer.VehicleNewsHandler(customer.PresentAnnouncement));

            businessCustomers.Add(customer);
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

        public void registerSalesContract(PrivateCustomer pc, Car car, double totalprice)
        {
            salesContracts.Add(new Sale(pc,car,totalprice));
        }

        public void registerLeasingContract(BusinessCustomer bc, Truck truck, double totalPrice, double monthlyPrice)
        {
            leasingContracts.Add(new Leasing(bc,truck,totalPrice,monthlyPrice));
        }

        public List<Sale> getSalesContracts()
        {
            return salesContracts;
        }

        public List<Leasing> getLeasingContracts()
        {
            return leasingContracts;
        }
    }
}
