namespace csharp_oop_1_demo
{
    public class SavingAccount : Account
    {
        public int Interests
        { get; }

        public SavingAccount(int balance, int interest) : base(balance)
        {
            Interests = interest;
        }
    }
}