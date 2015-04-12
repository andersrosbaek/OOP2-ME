using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Customer
    {
        public string Address { set; get; }
        public int Phone { set; get; }
        public string Name { set; get; }
        public bool IsVehicleNewsReciever { set; get; }

        public Customer(string address, int phone, string name, bool isVehicleNewsReciever)
        {
            Address = address;
            Phone = phone;
            Name = name;
            IsVehicleNewsReciever = isVehicleNewsReciever;
        }

        /**
         * Called if:
         * registered among listOfVehicleNewsRecievers using 
         * RegisterVehicleNewsReciever(VehicleNewsHandler methodToCall) in Cardealer.cs.
         * @msg Message to announce for the customer
         **/
        public void PresentAnnouncement(string msg)
        {
            if(IsVehicleNewsReciever)
                System.Diagnostics.Debug.WriteLine("Dear "+Name+", \n "+msg);
        }
    }
}
