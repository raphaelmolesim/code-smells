using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Text;

namespace Payroll.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void ShouldPrintTheAmountOfACheckingAccount()
        {
            var expected = "Credit made on account 123 from bank number 341, in the amount of 60, from checkings account";

            var consoleMock = new Mock<ConsoleApp>();

            var account = new CheckingsAccount(341, 123, consoleMock.Object);
            account.Credit(60);

            consoleMock.Verify(console => console.WriteLine(expected));
        }

        [TestMethod]
        public void ShouldPrintTheAmountOfASavingAccount()
        {
            var expected = "Credit made on account 123 from bank number 341, in the amount of 60, from savings account";

            var consoleMock = new Mock<ConsoleApp>();

            var account = new SavingsAccount(341, 123, consoleMock.Object);
            account.Credit(60);

            consoleMock.Verify(console => console.WriteLine(expected));
        }

    }
}
