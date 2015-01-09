using System;

namespace Payroll
{
    public class CheckingsAndSavingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;
        private ConsoleApp consoleApp;

        public CheckingsAndSavingsAccount(int bankNumber)
            : base(bankNumber)
        {
        }

        public CheckingsAndSavingsAccount(int bankNumber, int accountNumber) : base(bankNumber, accountNumber)
        {
        }

        public CheckingsAndSavingsAccount(int bankNumber, int accountNumber, ConsoleApp consoleApp) : base(bankNumber, accountNumber, consoleApp)
        {
        }

        public override string GetAccountTypeName()
        {
            return "checkings and savings account";
        }

    }
}