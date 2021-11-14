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
                totalBalance += account.GetTotalBalance();
            }

            return totalBalance;
        }
    }
}