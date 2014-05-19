namespace BankLibrary
{
    using System;
    using System.Linq;
    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (numberOfMonths < 4)
                {
                    return 0;
                }
                else
                {
                    return (numberOfMonths - 3) * this.InterestRate;
                }                
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (numberOfMonths < 3)
                {
                    return 0;
                }
                else
                {
                    return (numberOfMonths - 2) * this.InterestRate;
                }    
            }

            throw new ArgumentException("Invalid LoanAccount Customer");
        }
    }
}
