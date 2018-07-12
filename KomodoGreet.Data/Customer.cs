using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.Data
{
        
    public class Customer
    {
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public int ZipCode
        {
            get
            {
                return ZipCode;
            }
            private set
            {
                if (value > 6)
                {
                    throw new ArgumentException("ZipCode must be 6 digits long");
                }
                else
                {
                    ZipCode = value;
                }
            }
        }

        public Customer(string fullName, string address, string city, string state, int zipCode)
        {
            FullName = fullName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public Customer()
        {

        }
    }
}
