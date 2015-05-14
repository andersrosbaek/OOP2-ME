using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface ICustomer
    {
        /**
         * Called if:
         * registered among listOfVehicleNewsRecievers using 
         * RegisterVehicleNewsReciever(VehicleNewsHandler methodToCall) in Cardealer.cs.
         * @msg Message to announce for the customer
         **/
        void PresentAnnouncement(string msg);

        // To determine whether or not the customer is registed as news reciever
        bool CheckIfNewsReciever();
    }
}
