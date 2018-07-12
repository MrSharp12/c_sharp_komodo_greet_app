using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoContracts
{
    public interface IPresentCustomer
    {
        PresentCustomer CreatePresentCustomer(string fullName, string address, string city, string state, int zipCode);
        List<PresentCustomer> GetAllPresentCustomers();
        void AddPresentCustomerToList(PresentCustomer customer);
        string SendAppreciationMail();
    }
}
