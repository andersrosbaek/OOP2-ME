using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public partial class CustomerPrivate:Customer
    {
        public override string ToString()
        {
            return "Name: " + Name + ", Phone: " + Phone + ", Address" + Address + ", Age: " + Age+", Sex: "+Sex;
        }
    }
}
