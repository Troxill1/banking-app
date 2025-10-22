using BankingSystem.Core;
using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Forms
{
    public partial class StatisticsForm: Form
    {
        private BankAccount account;
        private Customer customer;

        public StatisticsForm(BankAccount account)
        {
            InitializeComponent();

            this.account = account;
            customer = Customer.customers.First(x => x.Name == account.HolderName);

            AccountLabel.Text += $" {account.ToString()?.ToLower()}";

            DisplayAggregates(account);
        }

        private void ReturnButton_Click(object sender, EventArgs e) => Hide();

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new();
            dialog.Filter = "JSON files (*.json)|*.json";
            dialog.FileName = $"statistics_{account.AccountNumber}.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(TransactionStats.ExportStats(dialog.FileName, account))
                {
                    MessageBox.Show("Статистиката беше успешно запазена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuditLog.Log(customer, $"Експорт на статистиката за {account}");
                }
                else
                    MessageBox.Show("Няма налична статистика за запазване", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAggregates(BankAccount account)
        {
            var accountTransactions = Transaction.transactions.Where(t => t.Account == account).ToList();

            if (!accountTransactions.Any())
            {
                StatisticsLabel.Text = "Няма налични транзакции";
                return;
            }

            double totalAmount = accountTransactions.Sum(t => t.Amount);
            double averageAmount = accountTransactions.Average(t => t.Amount);
            double maxAmount = accountTransactions.Max(t => t.Amount);
            double minAmount = accountTransactions.Min(t => t.Amount);
            int depositCount = accountTransactions.Count(t => t.Type == "deposit");
            int withdrawCount = accountTransactions.Count(t => t.Type == "withdraw");
            int loanPaymentCount = accountTransactions.Count(t => t.Type == "loan payment");

            StatisticsLabel.Text =
                $"- Общо преводи: {totalAmount:N2}лв\n" +
                $"- Средно преводи: {averageAmount:N2}лв\n" +
                $"- Най-голям превод: {maxAmount:N2}лв\n" +
                $"- Най-малък превод: {minAmount:N2}лв\n" +
                $"- Внасяния: {depositCount}\n" +
                $"- Изтегляния: {withdrawCount}\n" +
                $"- Плащания по кредит: {loanPaymentCount}";

            var typeTranslation = new Dictionary<string, string>
            {
                { "deposit", "Внасяне" },
                { "withdraw", "Изтегляне" },
                { "loan payment", "Плащане на кредит" },
                { "apply interest", "Прилагане на лихва" }
            };

            var typeGroups = accountTransactions
                .GroupBy(t => t.Type)
                .Select(g => $"{typeTranslation[g.Key]}: {g.Sum(t => t.Amount):N2}лв");

            StatisticsLabel.Text += "\n\nОбщо преводи по тип:\n" + string.Join("\n", typeGroups);

            AuditLog.Log(customer, $"Преглед на статистиката за {account}");
        }
    }
}
