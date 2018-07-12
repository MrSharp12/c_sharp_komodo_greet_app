using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.Data
{
    public class PastCustomer : Customer
    {
        public PastCustomer(string fullName, string address, string city, string state, int zipCode) : base(fullName, address, city, state, zipCode)
        {
        }
    }
}
