using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core.Operations
{
    public class ApplyInterestOperation : IAccountOperation
    {
        public string Type => "apply interest";

        public bool Execute(BankAccount account, double amount)
        {
            if (account is SavingsAccount savings)
            {
                Transaction.Execute(account, 0, Type);
                return true;
            }
            return false;
        }
    }
}
