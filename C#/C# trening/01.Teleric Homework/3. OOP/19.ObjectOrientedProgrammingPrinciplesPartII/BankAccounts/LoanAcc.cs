namespace BankAccounts
{
    using System;
    public class LoanAcc : Accounts,IOnlyDepositRight
    {
        public LoanAcc(Customers customer, decimal balance, int interestRate) : base(customer, balance, interestRate)
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
                if (mounths <= 3)
                {
                    return 0.0M;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounths - 3);
                }
            }
            else
            {
                if (mounths <= 2)
                {
                    return 0.0M;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounths - 2);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
