using KomodoContracts;
using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.BLL
{
    public class PotentialCustomerRepo : IPotentialCustomer

    {
        private List<PotentialCustomer> _potentialCustomer = new List<PotentialCustomer>();
        public PotentialCustomer CreatePotentialCustomer(string fullName, string address, string city, string state, int zipCode)
        {
            return new PotentialCustomer(fullName, address, city, state, zipCode);
        }

        public List<PotentialCustomer> GetAllPotentialCustomers()
        {
            return _potentialCustomer;
        }

        public void AddPotentalCustomerToList(PotentialCustomer customer)
        {
            _potentialCustomer.Add(customer);
        }

        public string SendJoinUsMail()
        {
            var message = "Please join us.  We have your best interest at heart.";
            return message;
        }
    }
}
