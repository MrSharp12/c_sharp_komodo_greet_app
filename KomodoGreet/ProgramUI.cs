using KomodoContracts;
using KomodoGreet.BLL;
using KomodoGreet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        public MasterList MasterList;
        public PastCustomerRepo PastCustomerRepo;
        public PotentialCustomerRepo PotentialCustomerRepo;
        public PresentCustomerRepo PresentCustomerRepo;

        public ProgramUI(IConsole consoleForAllReadsAndWrites)
        {
            _console = consoleForAllReadsAndWrites;
            MasterList = new MasterList();
            PastCustomerRepo = new PastCustomerRepo();
            PotentialCustomerRepo = new PotentialCustomerRepo();
            PresentCustomerRepo = new PresentCustomerRepo();
        }

        public void Run()
        {
            bool finished = false;

            do
            {
                _console.WriteLine("What would you like to do?\n " +
                                   "1. Add a customer\n " +
                                   "2. See all customers\n " +
                                   "3. See all past customers\n " +
                                   "4. See all present customers\n " +
                                   "5. See all potential customers\n " +
                                   "6. Search for customer\n " +
                                   "7. Exit program\n ");
                var command = _console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(command))
                {
                    finished = true;
                }
                else if (command == "1")
                {
                    CreateCustomer();
                }
                else if (command == "2")
                {
                    SeeAllCustomers();
                }
                else if (command == "3")
                {
                    SeeAllPastCustomers();
                }
                else if (command == "4")
                {
                    SeeAllPresentCustomers();
                }
                else if (command == "5")
                {
                    SeeAllPotentialCustomers();
                }
                else if (command == "6")
                {
                    Search();
                }
                else if (command == "7")
                {
                    finished = true;
                }
                else
                {
                    _console.WriteLine("Please enter a valid number");
                }

            } while (!finished);
        }


        public void CreateCustomer()
        {
            try
            {
                _console.WriteLine("What type of customer are you creating?\n" +
                              "1. Past\n" +
                              "2. Present\n" +
                              "3. Potential");
                var command = _console.ReadLine();
                if (command == "1")
                {
                    _console.WriteLine("Enter full name:");
                    var nameInput = _console.ReadLine();

                    _console.WriteLine("Enter street address:");
                    var streetAddressInput = _console.ReadLine();

                    _console.WriteLine("Enter city:");
                    var cityInput = _console.ReadLine();

                    _console.WriteLine("Enter state:");
                    var stateInput = _console.ReadLine();

                    _console.WriteLine("Enter zipcode:");
                    var zipCodeInput = Convert.ToInt32(_console.ReadLine());

                    var newPastCustomer = PastCustomerRepo.CreatePastCustomer(nameInput, streetAddressInput, cityInput, stateInput, zipCodeInput);
                    MasterList.AddCustomerToMasterList(newPastCustomer);
                    PastCustomerRepo.AddPastCustomerToList(newPastCustomer);
                    _console.WriteLine("Created customer");
                }
                if (command == "2")
                {
                    _console.WriteLine("Enter full name:");
                    var nameInput = _console.ReadLine();

                    _console.WriteLine("Enter street address:");
                    var streetAddressInput = _console.ReadLine();

                    _console.WriteLine("Enter city:");
                    var cityInput = _console.ReadLine();

                    _console.WriteLine("Enter state:");
                    var stateInput = _console.ReadLine();

                    _console.WriteLine("Enter zipcode:");
                    var zipCodeInput = Convert.ToInt32(_console.ReadLine());

                    var newPresentCustomer = PresentCustomerRepo.CreatePresentCustomer(nameInput, streetAddressInput, cityInput, stateInput, zipCodeInput);
                    MasterList.AddCustomerToMasterList(newPresentCustomer);
                    PresentCustomerRepo.AddPresentCustomerToList(newPresentCustomer);
                    _console.WriteLine("Created customer");
                }
                if (command == "3")
                {
                    _console.WriteLine("Enter full name:");
                    var nameInput = _console.ReadLine();

                    _console.WriteLine("Enter street address:");
                    var streetAddressInput = _console.ReadLine();

                    _console.WriteLine("Enter city:");
                    var cityInput = _console.ReadLine();

                    _console.WriteLine("Enter state:");
                    var stateInput = _console.ReadLine();

                    _console.WriteLine("Enter zipcode:");
                    var zipCodeInput = Convert.ToInt32(_console.ReadLine());

                    var newPotentialCustomer = PotentialCustomerRepo.CreatePotentialCustomer(nameInput, streetAddressInput, cityInput, stateInput, zipCodeInput);
                    MasterList.AddCustomerToMasterList(newPotentialCustomer);
                    PotentialCustomerRepo.AddPotentalCustomerToList(newPotentialCustomer);
                    _console.WriteLine("Created customer");
                }
                else
                {
                    _console.WriteLine("Please enter a valid number");
                }
            }
            catch (ArgumentException ex)
            {

                _console.WriteLine(ex.Message);
            }
        }

        public void SeeAllCustomers()
        {
            if (MasterList.GetAllCustomers().Count > 0)
            {
                _console.WriteLine("Display all customers");

                foreach (var customer in MasterList.GetAllCustomers())
                {
                    _console.WriteLine($"Name: {customer.FullName}\n" +
                                       $"Address: {customer.Address}\n" +
                                       $"City: {customer.City}\n" +
                                       $"State: {customer.State}\n" +
                                       $"ZipCode: {customer.ZipCode}");
                }
            }
            else
            {
                _console.WriteLine("The list is empty");
            }
        }

        public void SeeAllPastCustomers()
        {
            if (PastCustomerRepo.GetAllPastCustomers().Count > 0)
            {
                _console.WriteLine("Display all past customers");

                foreach (var customer in PastCustomerRepo.GetAllPastCustomers())
                {
                    _console.WriteLine($"Name: {customer.FullName}\n" +
                                       $"Address: {customer.Address}\n" +
                                       $"City: {customer.City}\n" +
                                       $"State: {customer.State}\n" +
                                       $"ZipCode: {customer.ZipCode}");
                }
            }
            else
            {
                _console.WriteLine("The list is empty");
            }
        }

        public void SeeAllPresentCustomers()
        {
            _console.WriteLine("Display all present customers");

            foreach (var customer in PresentCustomerRepo.GetAllPresentCustomers())
            {
                _console.WriteLine($"Name: {customer.FullName}\n" +
                                   $"Address: {customer.Address}\n" +
                                   $"City: {customer.City}\n" +
                                   $"State: {customer.State}\n" +
                                   $"ZipCode: {customer.ZipCode}");
            }
        }

        public void SeeAllPotentialCustomers()
        {
            if (PotentialCustomerRepo.GetAllPotentialCustomers().Count > 0)
            {
                _console.WriteLine("Display all potential customers");

                foreach (var customer in PotentialCustomerRepo.GetAllPotentialCustomers())
                {
                    _console.WriteLine($"Name: {customer.FullName}\n" +
                                       $"Address: {customer.Address}\n" +
                                       $"City: {customer.City}\n" +
                                       $"State: {customer.State}\n" +
                                       $"ZipCode: {customer.ZipCode}");
                }
            }
            else
            {
                _console.WriteLine("The list is empty");
            }
        }

        public void Search()
        {
            if (MasterList.GetAllCustomers().Count > 0)
            {
                _console.WriteLine("Enter full name of customer:");
                var name = _console.ReadLine();
                var contextedSearchInput = MasterList.Search(name);

                foreach (var customer in contextedSearchInput)
                {
                    if (customer.FullName == name)
                    {
                        _console.WriteLine($"Name: {customer.FullName}\n" +
                                           $"Address: {customer.Address}\n" +
                                           $"City: {customer.City}\n" +
                                           $"State: {customer.State}\n" +
                                           $"ZipCode: {customer.ZipCode}");
                    }
                }
            }
            else
            {
                _console.WriteLine("The list is empty");
            }
        }
    }
}
