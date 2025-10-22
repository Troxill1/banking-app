using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core.Operations
{
    public interface IAccountOperation
    {
        string Type { get; }

        bool Execute(BankAccount account, double amount); 
    }
}
