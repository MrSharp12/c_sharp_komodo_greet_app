using KomodoContracts;
using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.BLL
{
    public class PastCustomerRepo : IPastCustomer
    {
        private List<PastCustomer> _pastCustomerList = new List<PastCustomer>();
        public PastCustomer CreatePastCustomer(string fullName, string address, string city, string state, int zipCode)
        {
            return new PastCustomer(fullName, address, city, state, zipCode);
        }

        public List<PastCustomer> GetAllPastCustomers()
        {
            return _pastCustomerList;
        }

        public void AddPastCustomerToList(PastCustomer customer)
        {
            _pastCustomerList.Add(customer);
        }

        public string SendComeBackMail()
        {
            var message = "Please come back.  We have great rates!";
            return message;
        }
    }
}
