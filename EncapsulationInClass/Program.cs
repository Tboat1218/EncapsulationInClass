using System;

namespace EncapsulationInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0);

            Console.WriteLine("How much would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {account.Balance}");
        }
    }
}

