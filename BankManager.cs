using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    public class BankManager
    {
        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public int GetTotalBalance()
        {
            int totalBalance = 0;
            foreach (Account account in accounts)
            {
                if (account is SavingAccount s)
                {
                    totalBalance += s.Balance + s.Interests;
                }
                else
                {
                    totalBalance += account.Balance;
                }

            }

            return totalBalance;
        }
    }
}