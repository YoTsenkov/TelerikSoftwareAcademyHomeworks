namespace ATM.Client
{
    using System;
    using System.Linq;
    using System.Transactions;
    using ATM.Data;
    using ATM.Models;
    using System.Threading;

    internal static class AccountManager
    {
        public static void RetrieveMoneyFromAccount(ATMContext context, string cardPin, string cardNumber, decimal amount)
        {
            using (TransactionScope transaction = new TransactionScope(
                                                        TransactionScopeOption.Required,
                                                        new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
            {
                var card = VerifyCard(context, cardPin, cardNumber);
                if (card == null)
                {
                    throw new ArgumentNullException("The card does not exist.");
                }

                bool cardHasSufficientAmount = amount <= card.CardCash;
                if (!cardHasSufficientAmount)
                {
                    throw new Exception("The card has insufficient funds");
                }

                card.CardCash = card.CardCash - amount;
                context.SaveChanges();
                CreateLog(context, cardNumber, amount);
                //Here is where you can test the isolation level. It locks only the record(row) which is being modified,
                //the rest records from the table are selectable during the transaction.
                //Thread.Sleep(5000);
                transaction.Complete();
            }
        }

        private static CardAccount VerifyCard(ATMContext context, string cardPin, string cardNumber)
        {
            var card = context.CardAccounts.Where(account => account.CardPin == cardPin)
                                           .Where(account => account.CardNumber == cardNumber)
                                           .FirstOrDefault();

            if (card != null)
            {
                return card;
            }
            else
            {
                return null;
            }
        }

        private static void CreateLog(ATMContext context, string cardNumber, decimal amount)
        {
            using (TransactionScope transaction = new TransactionScope(
                    TransactionScopeOption.RequiresNew,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            {
                try
                {
                    context.TransactionHistories.Add(new TransactionHistory() { Amount = amount, CardNumber = cardNumber, TransactionDate = DateTime.Now, });
                    context.SaveChanges();
                    transaction.Complete();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
