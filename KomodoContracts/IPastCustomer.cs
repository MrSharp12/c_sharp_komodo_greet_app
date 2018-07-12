using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoContracts
{
    public interface IPastCustomer
    {
        PastCustomer CreatePastCustomer(string fullName, string address, string city, string state, int zipCode);
        List<PastCustomer> GetAllPastCustomers();
        void AddPastCustomerToList(PastCustomer customer);
        string SendComeBackMail();
    }
}
