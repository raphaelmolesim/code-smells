using System;

namespace Payroll
{
    public class Bank
    {
        private readonly int bankNumber;

        public Bank(int bankNumber)
        {
            this.bankNumber = bankNumber;
        }

        public Account GetAccountFor(AccountType accountType, int accountNumber)
        {
            switch (accountType)
            {
                case AccountType.CheckingsAccount:
                    return new CheckingsAccount(bankNumber, accountNumber);
                case AccountType.SavingsAccount:
                    return new SavingsAccount(bankNumber, accountNumber);
                case AccountType.CheckingsAndSavingsAccount:
                    return new CheckingsAndSavingsAccount(bankNumber, accountNumber);
            }
            //throws if account type is invalid
            throw new ArgumentException("account type not found", "accountType");
        }
    }
}