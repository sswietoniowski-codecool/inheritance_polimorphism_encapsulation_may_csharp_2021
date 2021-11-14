namespace csharp_oop_1_demo
{
    public class SavingAccount : Account
    {
        public int Interests
        { get; private set; }

        public SavingAccount(int balance = 0, int interest = 0) : base(balance)
        {
            Interests = interest;
        }


        public void IncreaseInterests(int amount)
        {
            Interests += amount;
        }

        public override int GetTotalBalance() => Balance + Interests;
    }
}