namespace csharp_oop_1_demo
{
    public class Account
    {
        public int Balance
        { get; private set; }

        public Account(int balance = 0)
        {
            Balance = balance;
        }

        public void IncreaseBalance(int amount)
        {
            Balance += amount;
        }

        public virtual int GetTotalBalance() => Balance;

    }
}