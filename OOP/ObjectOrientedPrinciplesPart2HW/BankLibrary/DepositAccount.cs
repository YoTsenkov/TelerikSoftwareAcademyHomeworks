namespace BankLibrary
{    
    public class DepositAccount : Account, IDeposit
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public void Deposit(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public void Withdraw(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return numberOfMonths * this.InterestRate;
            }
        }
    }
}
