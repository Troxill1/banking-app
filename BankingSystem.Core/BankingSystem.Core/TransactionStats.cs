using System.Text.Json;
using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core
{
    public class TransactionStats
    {
        public double TotalAmount { get; set; }
        public double AverageAmount { get; set; }
        public double MaxAmount { get; set; }
        public double MinAmount { get; set; }
        public int DepositCount { get; set; }
        public int WithdrawCount { get; set; }
        public int LoanPaymentCount { get; set; }
        public Dictionary<string, double>? GroupedTotals { get; set; }

        public static bool ExportStats(string filePath, BankAccount account)
        {
            var accountTransactions = Transaction.transactions.Where(t => t.Account == account).ToList();
            if (accountTransactions.Count == 0)
                return false;

            var stats = new TransactionStats
            {
                TotalAmount = accountTransactions.Sum(t => t.Amount),
                AverageAmount = accountTransactions.Average(t => t.Amount),
                MaxAmount = accountTransactions.Max(t => t.Amount),
                MinAmount = accountTransactions.Min(t => t.Amount),
                DepositCount = accountTransactions.Count(t => t.Type == "deposit"),
                WithdrawCount = accountTransactions.Count(t => t.Type == "withdraw"),
                LoanPaymentCount = accountTransactions.Count(t => t.Type == "loan payment"),
                GroupedTotals = accountTransactions
                    .GroupBy(t => t.Type)
                    .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount))
            };

            var json = JsonSerializer.Serialize(stats, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);

            return true;
        }
    }
}
