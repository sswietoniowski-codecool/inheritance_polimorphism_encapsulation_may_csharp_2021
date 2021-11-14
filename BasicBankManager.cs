using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class BasicBankManager
    {
        private List<BasicAccount> accounts = new List<BasicAccount>();

        public void AddAccount(BasicAccount account)
        {
            accounts.Add(account);
        }

        public int GetTotalBalance()
        {
            int totalBalance = 0;
            foreach (BasicAccount account in accounts)
            {
                totalBalance += account.GetTotalBalance();
            }

            return totalBalance;
        }
    }
}
