using System;

namespace Payroll
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(int bankNumber) : base(bankNumber)
        {
        }

        public SavingsAccount(int bankNumber, int accountNumber) : base(bankNumber, accountNumber)
        {
        }

        public SavingsAccount(int bankNumber, int accountNumber, ConsoleApp consoleApp)
            : base(bankNumber, accountNumber, consoleApp)
        {
    }

        public override string GetAccountTypeName()
        {
            return "savings account";
        }
    }
}