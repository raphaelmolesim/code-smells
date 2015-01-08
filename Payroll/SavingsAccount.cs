using System;

namespace Payroll
{
    //account type 200
    public class SavingsAccount : Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;
        private ConsoleApp consoleApp;

        public SavingsAccount(int bankNumber) : this(bankNumber, 0)
        {
        }

        public SavingsAccount(int bankNumber, int accountNumber) : this(bankNumber, accountNumber, new StaticConsole())
        {
        }

        public SavingsAccount(int bankNumber, int accountNumber, ConsoleApp consoleApp)
        {
            this.bankNumber = bankNumber;
            this.accountNumber = accountNumber;
            this.consoleApp = consoleApp;
        }

        public override void Credit(decimal amount)
        {
            var message = string.Format("Credit made on account {0} from bank number {1}, in the amount of {2}, from savings account", accountNumber, bankNumber, amount);
            consoleApp.WriteLine(message);
        }
    }
}