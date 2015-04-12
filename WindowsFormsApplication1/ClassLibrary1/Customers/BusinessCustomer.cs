using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class BusinessCustomer:Customer
    {
        public int SENumber { set; get; }
        public string ContactPerson { set; get; }
        public int Fax { set; get; }

        public BusinessCustomer(string address, int phone, int seNumber, string contactPerson, int fax, string companyName, bool isVehicleNewsReciever)
            : base(address, phone, companyName, isVehicleNewsReciever)
        {
            SENumber = seNumber;
            ContactPerson = contactPerson;
            Fax = fax;
        }

        public override string ToString()
        {
            return "Name: "+Name+", Contact Person: "+ContactPerson+", Phone: "+Phone+", Address"+Address+", SE #: "+SENumber;
        }
    }
}
