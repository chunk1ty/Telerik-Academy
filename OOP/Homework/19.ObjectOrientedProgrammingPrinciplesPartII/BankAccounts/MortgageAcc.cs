namespace BankAccounts
{
    using System;
    public class MortgageAcc : Accounts,IOnlyDepositRight
    {
        public MortgageAcc(Customers customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public void Deposit(decimal depositmoney)
        {
            if (depositmoney < 0)
            {
                throw new ArgumentException("You can not deposit negative value!");
            }
            this.Balance += depositmoney;
        }
        public override decimal CalculateInterestAmount(int mounths)
        {
            if (this.Customer == Customers.Individuals)
            {
                if (mounths <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounths - 6);
                }
            }
            else
            {
                if (mounths <= 12)
                {
                    return (this.Balance * (this.InterestRate / 2.0M)) * mounths;
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 2.0M)) * mounths + (this.Balance * this.InterestRate) * (mounths - 12);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
