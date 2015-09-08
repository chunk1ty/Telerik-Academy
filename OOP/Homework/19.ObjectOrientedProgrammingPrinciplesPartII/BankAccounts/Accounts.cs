namespace BankAccounts
{
    using System;
    public abstract class Accounts
    {
        //Fields
        private Customers custom;
        private decimal balan;
        private int rate;

        //Constructors
        public Accounts(Customers customer,decimal balance,int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //Properties
        public Customers Customer
        {
            get 
            { 
                return this.custom; 
            }
            set
            {
                this.custom = value;
            }
        }
        public decimal Balance
        {
            get 
            { 
                return this.balan; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Account balance can not be a negative number!");
                }
                this.balan = value; 
            }
        }
        public int InterestRate
        {
            get 
            { 
                return this.rate; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate can not be a negative number!");
                }
                this.rate = value; 
            }
        }                

        //Methods
        public virtual decimal CalculateInterestAmount(int mounths)
        {
            //return mounths * InterestRate;
            return (this.Balance * this.InterestRate) * mounths;
        }
    }
}
