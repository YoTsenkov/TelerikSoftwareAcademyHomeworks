namespace BankLibrary
{
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public void Deposit(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (numberOfMonths < 7)
                {
                    return 0;
                }
                else
                {
                    return (numberOfMonths - 6) * this.InterestRate;
                }
            }
            else
            {
                if (numberOfMonths < 13)
                {
                    return (numberOfMonths * this.InterestRate) / 2;
                }
                else
                {
                    return (numberOfMonths - 12) * this.InterestRate + (12 * this.InterestRate) / 2;
                }
            }
        }
    }
}
