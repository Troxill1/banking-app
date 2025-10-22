using System.Text.Json;
using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core
{
    public class Transaction
    {
        private string id;
        private readonly BankAccount account;
        private double amount;
        private string type;
        private string date;
        public static List<Transaction> transactions = new List<Transaction>();

        public string Id => id;
        public BankAccount Account => account;
        public double Amount => amount;
        public string Type => type;
        public DateTime Date => DateTime.Parse(date);

        private Transaction(string id, BankAccount account, double amount, string type, string date)
        {
            this.id = id;
            this.account = account;
            this.amount = amount;
            this.type = type;
            this.date = date;
        }

        public static bool Execute(BankAccount account, double amount, string type)
        {
            if (type == "deposit")
                account.Deposit(amount);
            else if (type == "withdraw")
            {
                if (!account.Withdraw(amount))
                    return false;
            }
            else if (type == "loan payment")
            {
                if (!((LoanAccount)account).MakePayment(amount))
                    return false;
            }
            else if (type == "apply interest")
                amount = ((SavingsAccount)account).ApplyInterest();
            else
                return false;

            string transactionId = Guid.NewGuid().ToString();
            string date = DateTime.Now.ToString();
            
            Transaction transaction = new Transaction(transactionId, account, amount, type, date);
            transactions.Add(transaction);

            return true;
        }

        public static string GetHistory(BankAccount account)
        {
            string history = $"История на транзакциите за банкова сметка {account.AccountNumber}\n";
            string temp = history;

            foreach (var transaction in transactions)
            {
                if (transaction.account == account)
                {
                    string transactionType = transaction.SwitchTransactionType();
                    history += $"[{transaction.date}] {transactionType}: {transaction.amount:N2}лв | ID: {transaction.id}\n";
                }             
            }

            if (history == temp)
                history += "Няма налични транзакции";

            return history;
        }

        public static string GetModifiedHistory(BankAccount account, List<Transaction> list)
        {
            string history = $"История на транзакциите за банкова сметка {account.AccountNumber}\n";
            string temp = history;

            foreach (var transaction in list)
            {
                string transactionType = transaction.SwitchTransactionType();
                history += $"[{transaction.Date}] {transactionType}: {transaction.Amount:N2}лв | ID: {transaction.Id}\n";
            }

            if (history == temp)
                history += "Няма налични транзакции";

            return history;
        }

        private string SwitchTransactionType()
        {
            string transactionType = Type switch
            {
                "deposit" => "Внасяне",
                "withdraw" => "Изтегляне",
                "loan payment" => "Плащане на кредит",
                "apply interest" => "Прилагане на лихва",
                _ => "Грешка"
            };

            return transactionType;
        }

        public static bool ExportHistory(string filePath)
        {
            if (transactions.Count == 0)
                return false;

            var transactionData = transactions.Select(t => new
            {
                t.Id,
                t.Account.AccountNumber,
                t.Amount,
                t.Type,
                t.Date
            }).ToList();

            var json = JsonSerializer.Serialize(transactionData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);

            return true;
        }
    }
}
