using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public partial class CustomerBusiness:Customer
    {
        public override string ToString()
        {
            return "Name: "+CompanyName+", Contact Person: "+ContactPerson+", Phone: "+Phone+", Address"+Address+", SE #: "+SENumber;
        }
    }
}
