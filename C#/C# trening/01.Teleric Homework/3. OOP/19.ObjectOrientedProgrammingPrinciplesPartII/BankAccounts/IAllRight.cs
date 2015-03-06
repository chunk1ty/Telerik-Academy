namespace BankAccounts
{
    interface IAllRight : IOnlyDepositRight
    {
        void Withdraw(decimal withdrawMoney);
    }
}
