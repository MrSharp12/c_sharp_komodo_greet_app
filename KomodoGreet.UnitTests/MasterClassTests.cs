using System;
using KomodoGreet.BLL;
using KomodoGreet.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreet.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private MasterList _masterListMethods;
        private PastCustomerRepo _pastCustomerRepo;
        private Customer newPastCustomer = new PastCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);


        [TestInitialize]
        public void Arrange()
        {
            _masterListMethods = new MasterList();
        }

        [TestMethod]
        public void MasterList_GetAllCustomersInList_ShouldSucceed()
        {
            //act
            _masterListMethods.AddCustomerToMasterList(newPastCustomer);
            _masterListMethods.GetAllCustomers();

            //assert
            Assert.AreEqual(1, _masterListMethods.GetAllCustomers().Count);
        }

        [TestMethod]
        public void MasterList_SearchCustomersInList_ShouldSucceed()
        {
            //act
            _masterListMethods.AddCustomerToMasterList(newPastCustomer);
            var listOfSearch = _masterListMethods.Search("Glenn Danzig");

            //assert
            Assert.AreEqual(listOfSearch[0].FullName, "Glenn Danzig");
        }
    }
}
