using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankManager bank = new BankManager();

            bank.AddAccount(new Account(1500));
            bank.AddAccount(new Account(-150));
            bank.AddAccount(new SavingAccount(1000, 100));

            Console.WriteLine($"Total balance is: {bank.GetTotalBalance()}");
        }

    }
}
