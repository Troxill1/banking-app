using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core.Operations
{
    public class PayLoanOperation : IAccountOperation
    {
        public string Type => "loan payment";

        public bool Execute(BankAccount account, double amount)
        {
            if (account is LoanAccount)
                return Transaction.Execute(account, amount, Type);
            return false;
        }
    }
}
