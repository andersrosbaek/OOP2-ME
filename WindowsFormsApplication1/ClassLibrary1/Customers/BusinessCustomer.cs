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
        public string NameOfCompany { set; get; }

        public BusinessCustomer(string address, int phone, int seNumber, string contactPerson, int fax, string companyName)
            : base(address, phone)
        {
            SENumber = seNumber;
            ContactPerson = contactPerson;
            Fax = fax;
            NameOfCompany = companyName;
        }
    }
}
