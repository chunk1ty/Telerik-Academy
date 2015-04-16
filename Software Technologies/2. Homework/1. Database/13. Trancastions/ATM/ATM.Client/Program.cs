namespace ATM.Client
{
    using ATM.Data;
    using ATM.Data.Migrations;
    using System.Data.Entity;
    using ATM.Models;
    using System.Data;
    using System.Linq;
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContextDb, Configuration>());

            using (var db = new ATMContextDb())
            {
                //db.CardAccount.Add(new CardAccount { CardNumber = "ank1", CardPIN = "ank1", CardCash = 200 });
                //db.CardAccount.Add(new CardAccount { CardNumber = "ank2", CardPIN = "ank2", CardCash = 400 });
                //db.CardAccount.Add(new CardAccount { CardNumber = "ank3", CardPIN = "ank3", CardCash = 500 });
                //db.CardAccount.Add(new CardAccount { CardNumber = "ank4", CardPIN = "ank4", CardCash = 600 });
                //db.SaveChanges();               
            }


        }

        private static void WinthDrawMoney(string pin, string cardNumber, decimal money, ATMContextDb context)
        {
            if (string.IsNullOrEmpty(pin))
            {
                throw new ArgumentException("Invalid card PIN");
            }

            if (string.IsNullOrEmpty(cardNumber))
            {
                throw new ArgumentException("Invalid card Number");
            }

            using (var tran = context.Database.BeginTransaction(IsolationLevel.RepeatableRead))
            {
                var card = context.CardAccount.Where(c => c.CardNumber == cardNumber).FirstOrDefault();

                if (card == null)
                {
                    throw new ArgumentException("The card doesn't exist");
                }

                if (card.CardCash < 200)
                {
                    throw new ArgumentException("Not enough money");
                }

                card.CardCash -= 200;
                context.SaveChanges();
            }
        }

        private static void AddTransactionToHistory(string cardNumber, decimal ammount, ATMContextDb context)
        {
            using (context)
            {
                using (var tran = context.Database.BeginTransaction(IsolationLevel.RepeatableRead))
                {
                    context.TransactionHistory.Add(new TransactionHistory()
                    {
                        TransactionDate = DateTime.Now,
                        Amount = ammount,
                        CardNumber = cardNumber
                    });

                    try
                    {
                        tran.Commit();
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }           
        }
    }
}
