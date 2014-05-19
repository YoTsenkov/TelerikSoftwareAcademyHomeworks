using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

using BankLibrary;

namespace _02.BankTest
{
    class BankTest
    {
        static void Main()
        {
            var depositAcc = new DepositAccount(new CompanyCustomer(), 150, 5);
            var loanAcc = new LoanAccount(new IndividualCustomer(), 50, 3);
            var mortgageAcc = new MortgageAccount(new CompanyCustomer(), 1500, 8);
        }
    }
}
