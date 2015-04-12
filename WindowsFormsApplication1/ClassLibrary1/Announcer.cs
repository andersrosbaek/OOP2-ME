using Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Announcer
    {
        private static Announcer instance;
        public static Announcer getInstance()
        {
            if (instance == null)
            {
                instance = new Announcer();
            }

            return instance;
        }

        // Define Delegate + declare af member of that delegate
        // (Used when new cars are put into the system and business)
        public delegate void VehicleNewsHandler(string newsAboutNewVehicle);
        private VehicleNewsHandler listOfVehicleNewsRecievers;

        // The methods below registers/un-registers those who should recieve fax about new vehicles
        /* The overload operator "+=" enables multicast, which just is a list of mehods to call.*/
        public void RegisterVehicleNewsReciever(VehicleNewsHandler methodToCall) { listOfVehicleNewsRecievers += methodToCall; }
        public void UnRegisterVehicleNewsReciever(VehicleNewsHandler methodToCall) { listOfVehicleNewsRecievers -= methodToCall; }

        public void AnnounceNewVehicle(IVehicle v)
        {
            listOfVehicleNewsRecievers("We are proud to bring you the news of our new " + v.Type + " model " + v.Model + " available in the color " + v.Color + " for only "+v.Price+"!. \n Best regards,\nus");
        }
    }
}
