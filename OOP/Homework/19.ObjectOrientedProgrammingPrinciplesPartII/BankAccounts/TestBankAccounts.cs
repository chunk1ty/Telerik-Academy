namespace BankAccounts
{
    using System;
    class TestBankAccounts
    {
        static void Main()
        {
            DepositAcc depAcc = new DepositAcc(Customers.Individuals, 1100, 10);
            //depAcc.Withdraw(300);
            //Console.WriteLine(depAcc.ToString());
            //Console.WriteLine(depAcc.CalculateInterestAmount(3));

            LoanAcc loanAcc = new LoanAcc(Customers.Companies, 17000, 17);
            LoanAcc loanAccI = new LoanAcc(Customers.Individuals, 17000, 17);

            //Console.WriteLine(loanAcc.CalculateInterestAmount(6));
            //Console.WriteLine(loanAccI.CalculateInterestAmount(6));
        }
    }
}
