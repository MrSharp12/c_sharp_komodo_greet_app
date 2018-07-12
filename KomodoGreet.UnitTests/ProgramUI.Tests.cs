using System;
using KomodoContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreet.UnitTests
{
    [TestClass]
    public class ProgramUITests
    {
        
        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreatePastCustomer_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "1","Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "2" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }
        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreateCustomerAndSearchAllCustomers_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "1", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "2" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "Matt Sharp");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreateCustomerAndSearchPastCustomers_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "1", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "3" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "Matt Sharp");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreateCustomerAndSearchPresentCustomers_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "2", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "4" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "Matt Sharp");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreateCustomerAndSearchPotentialCustomers_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "3", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "5" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "Matt Sharp");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreateCustomerAndSearchSpecificCustomer_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "3", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "6", "Matt Sharp" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "Matt Sharp");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreatePresentCustomer_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "2", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "3" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_CreatePotentialCustomer_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "3", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "4" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }

        [TestMethod]
        public void ProgramUI_TestsCommand_OptionFive_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "5" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_OptionSix_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "6" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }

        [TestMethod]
        public void ProgramUI_TestsCommandOne_OptionSeven_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] { "1", "Matt Sharp", "7120 New Road", "Indianapolis", "IN", "46250", "7" });
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }

        [TestMethod]
        public void ProgramUI_TestsSearchAllThrowsErrorMessage_ShouldSucceed()
        {
            //Arrange
            var mockConsole = new MockConsole(new string[] {"2"});
            var programUI = new ProgramUI(mockConsole);

            //Act
            programUI.Run();

            //Assert

            var outputText = mockConsole.Output;
            StringAssert.Contains(outputText, "What would you like to do?");
        }
    }
}
