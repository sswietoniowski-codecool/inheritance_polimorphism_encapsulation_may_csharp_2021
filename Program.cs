using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankManager bank = new BankManager();

            Account account1 = new Account();
            account1.IncreaseBalance(500);

            Account account2 = new Account(1000);
            account2.IncreaseBalance(1000);

            SavingAccount savaccount1 = new SavingAccount(interest: 200);
            savaccount1.IncreaseBalance(5000);
            savaccount1.IncreaseInterests(100);


            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.AddAccount(savaccount1);


            Console.WriteLine($"Total balance is: {bank.GetTotalBalance()}");
        }
    }
}
