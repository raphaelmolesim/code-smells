using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payroll.Test
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void ShouldCreateACheckingAccount()
        {
            var account = new Bank(341).GetAccountFor(AccountType.CheckingsAccount, 245869);
            Assert.IsInstanceOfType(account, typeof(CheckingsAccount));
        }

        [TestMethod]
        public void ShouldCreateASavingsAccount()
        {
            var account = new Bank(341).GetAccountFor(AccountType.SavingsAccount, 245869);
            Assert.IsInstanceOfType(account, typeof(SavingsAccount));
        }

        [TestMethod]
        public void ShouldCreateACheckingsAndSavingsAccount()
        {
            var account = new Bank(341).GetAccountFor(AccountType.CheckingsAndSavingsAccount, 245869);
            Assert.IsInstanceOfType(account, typeof(CheckingsAndSavingsAccount));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotCreateAAccount()
        {
            var account = new Bank(341).GetAccountFor((AccountType)400, 245869);
            Assert.Fail("It should not have created the Account");
        }
       
    }
}
