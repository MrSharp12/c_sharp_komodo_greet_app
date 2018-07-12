using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.Data
{
    public class PotentialCustomer : Customer
    {
        public PotentialCustomer(string fullName, string address, string city, string state, int zipCode) : base(fullName, address, city, state, zipCode)
        {
        }
    }
}
