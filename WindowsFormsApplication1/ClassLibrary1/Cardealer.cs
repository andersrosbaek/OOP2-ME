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
        private List<CustomerPrivate> privateCustomers  = new List<CustomerPrivate>();
        private List<CustomerBusiness> businessCustomers = new List<CustomerBusiness>();

        private List<VehicleCar> cars = new List<VehicleCar>();
        private List<VehicleTruck> trucks = new List<VehicleTruck>();

        private List<ContractSale> salesContracts = new List<ContractSale>();
        private List<ContractLeasing> leasingContracts = new List<ContractLeasing>();

        private static Cardealer instance;
        public static Cardealer getInstance()
        {
            if (instance == null)
            {
                instance = new Cardealer();
                new DirectoryWatcher();

                // Go through existing customers in database to register them so as they
                // can recieve news of new vehicles that are registered in the system.
                registerExistingNewsRecievers(getInstance().getPrivateCustomers());
                registerExistingNewsRecievers(getInstance().getBusinessCustomers());
            }

            return instance;
        }

        private static void registerExistingNewsRecievers<T> (List<T> customerList)
        {
            Type typeParameterType = typeof(T);

            int length = customerList.Count;
            for (int i = 0; i < length; i++)
            {
                ICustomer customer = (customerList[i] as ICustomer);

                if (customer.CheckIfNewsReciever() == true)
                {
                    Announcer.getInstance().RegisterVehicleNewsReciever(customer.PresentAnnouncement);
                }
            }
        }

        public void registerCar(string type, string model, string color, double price)
        {
            // Create new car with provided informations
            VehicleCar car = new VehicleCar();
            car.Color = color;
            car.Model = model;
            car.Price = (int) price;
            car.Type = type;

            // Save changes to database
            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.VehicleCars.Add(car);
                context.SaveChanges();
            }

            // Annouce Vehicle to news recievers
            Announcer.getInstance().AnnounceNewVehicle(type, model, color, price.ToString());
        }

        public void removeCar(int ID)
        {
            VehicleCar car;

            using (AutoLotEntities context = new AutoLotEntities())
            {
                car = context.VehicleCars.Find(ID);
                context.VehicleCars.Remove(car);
                context.SaveChanges();
            }
        }

         public void registerTruck(string type, string model, string color, double price)
        {
            // Create new car with provided informations
            VehicleTruck truck = new VehicleTruck();
            truck.Color = color;
            truck.Model = model;
            truck.Price = (int) price;
            truck.Type = type;

            // Save changes to database
            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.VehicleTrucks.Add(truck);
                context.SaveChanges();
            }

            Announcer.getInstance().AnnounceNewVehicle(type, model, color, price.ToString());
        }

         public void removeTruck(int ID)
         {
             VehicleTruck car;

             using (AutoLotEntities context = new AutoLotEntities())
             {
                 car = context.VehicleTrucks.Find(ID);
                 context.VehicleTrucks.Remove(car);
                 context.SaveChanges();
             }
         }

        public void registerPrivateCustomer(string address, int phone, string name, DateTime age, string sex, bool isVehicleNewsReciever)
        {
            CustomerPrivate customerPrivate = new CustomerPrivate();
            customerPrivate.Name = name;
            customerPrivate.Address = address;
            customerPrivate.Phone = phone;
            customerPrivate.Age = age;
            customerPrivate.NewsReciever = isVehicleNewsReciever;
            customerPrivate.Sex = sex;


            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.CustomerPrivates.Add(customerPrivate);
                context.SaveChanges();
            }

            // Check whether to register and Register costumer as a Vehicle news reciever
            if (isVehicleNewsReciever)
                Announcer.getInstance().RegisterVehicleNewsReciever(new Announcer.VehicleNewsHandler(customerPrivate.PresentAnnouncement));
        }

        public void registerBusinessCustomer(string address, int phone, int seNumber, string contactPerson, int fax, string companyName, bool isVehicleNewsReciever)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();
            customerBusiness.CompanyName = companyName;
            customerBusiness.Address = address;
            customerBusiness.Phone = phone;
            customerBusiness.ContactPerson = contactPerson;
            customerBusiness.Fax = fax;
            customerBusiness.NewsReciever = isVehicleNewsReciever;
            customerBusiness.SENumber = seNumber;

            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.CustomerBusinesses.Add(customerBusiness);
                context.SaveChanges();
            }

            // Check whether to register and Register costumer as a Vehicle news reciever
            if(isVehicleNewsReciever)
                Announcer.getInstance().RegisterVehicleNewsReciever(new Announcer.VehicleNewsHandler(customerBusiness.PresentAnnouncement));
        }

        public List<CustomerPrivate> getPrivateCustomers()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.CustomerPrivates.ToList<CustomerPrivate>();
            }
        }

        public List<CustomerBusiness> getBusinessCustomers()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.CustomerBusinesses.ToList<CustomerBusiness>();
            }
        }

        public List<VehicleCar> getCars()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.VehicleCars.ToList<VehicleCar>();
            }
        }

        public List<VehicleTruck> getTrucks()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.VehicleTrucks.ToList<VehicleTruck>();
            }
        }

        public void registerSalesContract(CustomerPrivate customerPrivate, VehicleCar car, double totalprice)
        {
            ContractSale sale = new ContractSale();
            sale.VehicleCarID = car.VehicleCarID;
            sale.Date = new DateTime();
            
            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.ContractSales.Add(sale);
                context.SaveChanges();
            }
        }

        public void registerLeasingContract(CustomerBusiness customerBusiness, VehicleTruck truck, double totalPrice, double monthlyPrice)
        {
            ContractLeasing leasing = new ContractLeasing();
            leasing.VehicleTruckID = truck.VehicleTruckID;
            leasing.SENumber = customerBusiness.SENumber;
            leasing.MonthlyPrice = (decimal) monthlyPrice;
            leasing.Date = new DateTime();

            using (AutoLotEntities context = new AutoLotEntities())
            {
                context.ContractLeasings.Add(leasing);
                context.SaveChanges();
            }
        }

        public List<ContractSale> getSalesContracts()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.ContractSales.ToList<ContractSale>();
            }
        }

        public List<ContractLeasing> getLeasingContracts()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                return context.ContractLeasings.ToList<ContractLeasing>();
            }
        }
    }
}
