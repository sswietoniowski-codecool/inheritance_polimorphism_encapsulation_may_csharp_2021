using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BankManager bank = new BankManager();

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


            Console.WriteLine($"Total balance is: {bank.GetTotalBalance()}");*/

            BasicAccount account1 = new BasicAccount(AccountType.Current);
            account1.IncreaseBalance(500);

            BasicAccount account2 = new BasicAccount(AccountType.Current);
            account2.IncreaseBalance(2000);

            BasicAccount account3 = new BasicAccount(AccountType.Saving);
            account3.IncreaseBalance(5000);
            account3.IncreaseInterests(300);

            BasicBankManager basicBank = new BasicBankManager();
            basicBank.AddAccount(account1);
            basicBank.AddAccount(account2);
            basicBank.AddAccount(account3);

            Console.WriteLine($"Total balance is: {basicBank.GetTotalBalance()}");

        }
    }
}
