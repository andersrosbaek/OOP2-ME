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
        /**
         * Called if:
         * registered among listOfVehicleNewsRecievers using 
         * RegisterVehicleNewsReciever(VehicleNewsHandler methodToCall) in Cardealer.cs.
         * @msg Message to announce for the customer
         **/
        public void PresentAnnouncement(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
