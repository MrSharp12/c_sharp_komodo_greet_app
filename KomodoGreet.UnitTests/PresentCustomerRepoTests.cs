using System;
using KomodoGreet.BLL;
using KomodoGreet.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreet.UnitTests
{
    [TestClass]
    public class PresentCustomerRepoTests
    {
        private PresentCustomerRepo _presentCustomerRepo;

        [TestInitialize]
        public void Arrange()
        {
            _presentCustomerRepo = new PresentCustomerRepo();
        }

        [TestMethod]
        public void PresentCustomerRepo_CreatePresentCustomerMethod_ShouldSucceed()
        {
            //act
            var actual = _presentCustomerRepo.CreatePresentCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

            //assert
            Assert.IsInstanceOfType(actual, typeof(PresentCustomer));
        }

        [TestMethod]
        public void PresentCustomerRepo_AddPresentCustomerToListMethod_ShouldSucceed()
        {
            //act
            var newPresentCustomer = _presentCustomerRepo.CreatePresentCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);
            _presentCustomerRepo.AddPresentCustomerToList(newPresentCustomer);
            _presentCustomerRepo.GetAllPresentCustomers();

            //assert
            Assert.AreEqual(1, _presentCustomerRepo.GetAllPresentCustomers().Count);
        }

        [TestMethod]
        public void PresentCustomerRepo_SendAppreciationMailMethod_ShouldSucceed()
        {
            //act
            var newPresentCustomer = _presentCustomerRepo.CreatePresentCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

            var expected = "Thanks for being a customer.  Enjoy these two free movie tickets!";
            var actual = _presentCustomerRepo.SendAppreciationMail();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
