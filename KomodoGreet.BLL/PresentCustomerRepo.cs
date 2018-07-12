using KomodoContracts;
using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.BLL
{
    public class PresentCustomerRepo : IPresentCustomer
    {
        private List<PresentCustomer> _presentCustomer = new List<PresentCustomer>();
        public PresentCustomer CreatePresentCustomer(string fullName, string address, string city, string state, int zipCode)
        {
            return new PresentCustomer(fullName, address, city, state, zipCode);
        }

        public List<PresentCustomer> GetAllPresentCustomers()
        {
            return _presentCustomer;
        }

        public void AddPresentCustomerToList(PresentCustomer customer)
        {
            _presentCustomer.Add(customer);
        }
        public string SendAppreciationMail()
        {
            var message = "Thanks for being a customer.  Enjoy these two free movie tickets!";
            return message;
        }
    }
}
