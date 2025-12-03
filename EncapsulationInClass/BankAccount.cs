namespace EncapsulationInClass
{
    public class BankAccount
    {
        // 1) Private field – ONLY this class can touch it directly
        private double balance = 0;

        // 2) Public property – other code can READ the balance, but not change it
        public double Balance
        {
            get { return balance; }      // allows read access
            private set { balance = value; } // only BankAccount can set it
        }

        // 3) Constructor – runs when you create a new BankAccount
        public BankAccount(double initialAmount)
        {
            Balance = initialAmount;
        }

        // 4) Deposit – add money
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // 5) Withdraw – remove money
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        // 6) Optional method – another way to read the balance
        public double GetBalance()
        {
            return Balance;
        }
    }
}

