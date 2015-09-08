namespace BankAccounts
{
    using System;
    public class DepositAcc : Accounts,IAllRight
    {
        public DepositAcc(Customers customer,decimal balance,int interestRate):base(customer,balance,interestRate)
        {
        }

        public void Withdraw(decimal withdrawMoney)
        {
            if (withdrawMoney < 0)
            {
                throw new ArgumentException("You can not withdraw negative value!");
            }
            if (this.Balance < withdrawMoney)
            {
                throw new ArithmeticException("You don't have enouth money for withdraw!");
            }
            this.Balance -= withdrawMoney;
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
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return this.Balance;
            }
            else
            {
                return (this.Balance * this.InterestRate) * mounths;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
