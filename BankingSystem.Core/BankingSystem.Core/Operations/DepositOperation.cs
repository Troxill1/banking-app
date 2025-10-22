using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core.Operations
{
    public class DepositOperation : IAccountOperation
    {
        public string Type => "deposit";

        public bool Execute(BankAccount account, double amount)
        {
            Transaction.Execute(account, amount, Type);
            return true;
        }
    }
}
