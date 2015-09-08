namespace ATM.Data
{
    using ATM.Models;
    using Migrations;
    using System.Data.Entity;

    public class ATMContextDb : DbContext
    {
        public ATMContextDb()
            : base("ATMContextDb") 
        {
           
        }

        public DbSet<CardAccount> CardAccount { get; set; }

        public DbSet<TransactionHistory> TransactionHistory { get; set; }
    }
}
