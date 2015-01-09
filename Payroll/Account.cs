namespace Payroll
{
    public abstract class Account
    {
        private readonly int bankNumber;
        private readonly int accountNumber;
        private ConsoleApp consoleApp;

        public Account(int bankNumber) : this(bankNumber, 0)
        {
        }

        public Account(int bankNumber, int accountNumber) : this(bankNumber, accountNumber, new StaticConsole())
        {
        }

        public Account(int bankNumber, int accountNumber, ConsoleApp consoleApp)
        {
            this.bankNumber = bankNumber;
            this.accountNumber = accountNumber;
            this.consoleApp = consoleApp;
        }

        public void Credit(decimal amount)
        {
            var message = string.Format("Credit made on account {0} from bank number {1}, in the amount of {2}, from {3}", accountNumber, bankNumber, amount, GetAccountTypeName());
            consoleApp.WriteLine(message);
        }

        public abstract string GetAccountTypeName();
    }
}