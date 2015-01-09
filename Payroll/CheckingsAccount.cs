using System;

namespace Payroll
{
    public class CheckingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;
        private ConsoleApp consoleApp;

        public CheckingsAccount(int bankNumber)
            : base(bankNumber)
        {            
        }

        public CheckingsAccount(int bankNumber, int accountNumber)
            : base(bankNumber, accountNumber)
        {            
        }

        public CheckingsAccount(int bankNumber, int accountNumber, ConsoleApp consoleApp)
            : base(bankNumber, accountNumber, consoleApp)
        {
        }

        public override string GetAccountTypeName()
        {
            return "checkings account";
        }
    }
}