using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    enum AccountType
    {
        Current,
        Saving
    }

    class BasicAccount
    {
        AccountType accountType;
        public int Balance { get; private set; } = 0;
        public int Interests { get; private set; } = 0;

        public BasicAccount(AccountType accountType)

        {
            this.accountType = accountType;
        }
        public void IncreaseBalance(int amount)
        {
            Balance += amount;
        }

        public void IncreaseInterests(int amount)
        {
            if (accountType != AccountType.Saving)
            {
                throw new NotImplementedException("Account is not saving account");
            }
            Interests += amount;
        }

        public int GetTotalBalance()
        {
        
            if (accountType == AccountType.Current)
            {
                return Balance;
            }
            else if (accountType == AccountType.Saving)
            {
                return Balance + Interests;
            }
            else
            {
                throw new NotImplementedException("This kind of account is not supported");
            }
        }



    }
}
