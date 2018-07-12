using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoContracts
{
    public interface IPotentialCustomer
    {
        PotentialCustomer CreatePotentialCustomer(string fullName, string address, string city, string state, int zipCode);
        List<PotentialCustomer> GetAllPotentialCustomers();
        void AddPotentalCustomerToList(PotentialCustomer customer);
        string SendJoinUsMail();
    }
}
