namespace BankLibrary
{
    public abstract class Account
    {
        public Customer Customer { get; protected set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        public abstract decimal CalculateInterest(int numberOfMonths);
             
    }
}
