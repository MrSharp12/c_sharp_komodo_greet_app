using System;
using KomodoGreet.BLL;
using KomodoGreet.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreet.UnitTests
{
    [TestClass]
    public class PotentialCustomerRepoTests
    {
        private PotentialCustomerRepo _potentialCustomerRepo;

        [TestInitialize]
        public void Arrange()
        {
            _potentialCustomerRepo = new PotentialCustomerRepo();
        }

        [TestMethod]
        public void PotentialCustomerRepo_CreatePotentialCustomerMethod_ShouldSucceed()
        {
            //act
            var actual = _potentialCustomerRepo.CreatePotentialCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

            //assert
            Assert.IsInstanceOfType(actual, typeof(PotentialCustomer));
        }

        [TestMethod]
        public void PotentialCustomerRepo_AddPastCustomerToListMethod_ShouldSucceed()
        {
            //act
            var newPotentialCustomer = _potentialCustomerRepo.CreatePotentialCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);
            _potentialCustomerRepo.AddPotentalCustomerToList(newPotentialCustomer);
            _potentialCustomerRepo.GetAllPotentialCustomers();

            //assert
            Assert.AreEqual(1, _potentialCustomerRepo.GetAllPotentialCustomers().Count);
        }

        [TestMethod]
        public void PotentialCustomerRepo_SendJoinUsMailMethod_ShouldSucceed()
        {
            //act
            var newPotentialCustomer = _potentialCustomerRepo.CreatePotentialCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

            var expected = "Please join us.  We have your best interest at heart.";
            var actual = _potentialCustomerRepo.SendJoinUsMail();

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
