namespace ATM.Client
{
    using System;
    using System.Linq;
    using ATM.Models;
    using ATM.Data;
    using ATM.Data.Migrations;
    using System.Data.Entity;

    internal class Client
    {
        static void Main(string[] args)
        {
            Database.SetInitializer
                (new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());
            var atmContext = new ATMContext();           
            using (atmContext)
            {
                atmContext.CardAccounts.Add(new CardAccount() { CardCash = 10000, CardNumber = "12356asdf", CardPin = "1234" });
                atmContext.CardAccounts.Add(new CardAccount() { CardCash = 5000, CardNumber = "78901asdf", CardPin = "4321" });
                atmContext.SaveChanges();
                
                AccountManager.RetrieveMoneyFromAccount(atmContext, "1234", "12356asdf", 666);
            }
        }
    }
}
