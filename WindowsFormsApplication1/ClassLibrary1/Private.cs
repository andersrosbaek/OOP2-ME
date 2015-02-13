using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class Private:Customer
    {
        public string Name { set; get; }
        public DateTime Age { set; get; }
        public enum Sex { Male, Female, Turtle }
    }
}
