using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core.Operations
{
    public class WithdrawOperation : IAccountOperation
    {
        public string Type => "withdraw";

        public bool Execute(BankAccount account, double amount)
        {
            return Transaction.Execute(account, amount, Type);
        }
    }
}
