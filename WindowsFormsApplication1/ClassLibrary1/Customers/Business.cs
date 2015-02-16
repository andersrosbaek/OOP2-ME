using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Business:Customer
    {
        public int SENumber { set; get; }
        public string ContactPerson { set; get; }
        public int Fax { set; get; }
        public string NameOfCompany { set; get; }
    }
}
