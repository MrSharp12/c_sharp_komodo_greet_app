using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.BLL
{
    public class MasterList
    {
        private List<Customer> _masterList = new List<Customer>();

        public void AddCustomerToMasterList(Customer customer)
        {
            _masterList.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _masterList;
        }

        public List<Customer> Search(string searchText)
        {
            var contextedList = new List<Customer>();

            if (_masterList != null)
            {
                foreach (var customer in _masterList)
                {
                    if (customer.FullName == searchText)
                    {
                        contextedList.Add(customer);
                    }
                }
            }
            
            return contextedList;
        }
    }
}
