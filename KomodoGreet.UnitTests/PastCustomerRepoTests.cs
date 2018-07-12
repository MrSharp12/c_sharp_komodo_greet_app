using System;
using KomodoGreet.BLL;
using KomodoGreet.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreet.UnitTests
{
    [TestClass]
    public class PastCustomerRepoTests
    {
        [TestClass]
        public class UnitTest1
        {
            private PastCustomerRepo _pastCustomerRepo;
            private PastCustomer newPastCustomer2 = new PastCustomer("Frankenstein", "23 Frankenstein Castle", "Indianapolis", "IN", 234567);
            [TestInitialize]
            public void Arrange()
            {
                _pastCustomerRepo = new PastCustomerRepo();
            }

            [TestMethod]
            public void PastCustomerRepo_CreatePastCustomerMethod_ShouldSucceed()
            {
                //act
                var actual = _pastCustomerRepo.CreatePastCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

                //assert
                Assert.IsInstanceOfType(actual, typeof(PastCustomer));
            }

            [TestMethod]
            public void PastCustomerRepo_AddPastCustomerToListMethod_ShouldSucceed()
            {
                //act
                var newPastCustomer = _pastCustomerRepo.CreatePastCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);
                _pastCustomerRepo.AddPastCustomerToList(newPastCustomer);
                _pastCustomerRepo.GetAllPastCustomers();

                //assert
                Assert.AreEqual(1, _pastCustomerRepo.GetAllPastCustomers().Count);
            }

            [TestMethod]
            public void PastCustomerRepo_SendComeBackMailMethod_ShouldSucceed()
            {
                //act
                var newPastCustomer = _pastCustomerRepo.CreatePastCustomer("Glenn Danzig", "666 Darkness Street", "Hoboken", "NJ", 567890);

                var expected = "Please come back.  We have great rates!";
                var actual = _pastCustomerRepo.SendComeBackMail();

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
