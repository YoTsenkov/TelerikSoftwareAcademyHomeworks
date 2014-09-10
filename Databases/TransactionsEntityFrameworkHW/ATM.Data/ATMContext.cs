namespace ATM.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ATM.Models;

    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATMDB")
        {
        }

        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}
