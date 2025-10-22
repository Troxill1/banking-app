using BankingSystem.Core;
using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Forms
{
    public partial class TransactionHistoryForm : Form
    {
        private MainMenuForm sender;
        private BankAccount account;
        private Customer customer;
        private static readonly List<Transaction> transactions = Transaction.transactions;
        private string? selectedFilter = "";

        public TransactionHistoryForm(MainMenuForm sender, BankAccount account)
        {
            InitializeComponent();

            this.sender = sender;
            this.account = account;
            customer = Customer.customers.First(x => x.Name == account.HolderName);

            HistoryLabel.Text = Transaction.GetHistory(account);
            HistoryLabel.SelectAll();
            HistoryLabel.SelectionAlignment = HorizontalAlignment.Center;

            if (account is LoanAccount loanAccount)
            {
                BalanceLabel.Text = $"Оставащ кредит: {loanAccount.RemainingLoan:N}лв" +
                    $"\nИзлатени месеци: {loanAccount.PaidEMIs}/{loanAccount.LoanPeriod}";
                EmiLabel.Text = $"Оставащ EMI: {loanAccount.EMI:N}лв";
            }
            else
                BalanceLabel.Text = $"Наличност: {this.account.GetBalance()}лв";

            HideActionElements();

            AuditLog.Log(customer, $"Преглед на историята на транзакциите за {account}");
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
            this.sender.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new();
            dialog.Filter = "JSON files (*.json)|*.json";
            dialog.FileName = $"transactions_{account.AccountNumber}.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Transaction.ExportHistory(dialog.FileName))
                {
                    MessageBox.Show("Историята на транзакциите беше успешно запазена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuditLog.Log(customer, $"Експорт на историята на транзакциите за {account}");
                }
                else
                    MessageBox.Show("Няма налични транзакции за запазване", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterDropdown.SelectedIndex == -1)
                return;

            HideActionElements();
            ResetActionElements();
            SortDropdown.SelectedIndex = -1;
            TypeDropdown.SelectedIndex = -1;

            string? selectedItem = FilterDropdown.SelectedItem as string;
            selectedFilter = selectedItem;

            if (selectedItem == "Дата")
            {
                FromLabel.Show();
                ToLabel.Show();
                FromDatePicker.Show();
                ToDatePicker.Show();
            }
            else if (selectedItem == "Сума")
            {
                FromLabel.Show();
                ToLabel.Show();
                FromAmountInput.Show();
                ToAmountInput.Show();
            }
            else if (selectedItem == "Тип")
            {
                TypeLabel.Show();
                TypeDropdown.Show();
            }

            SubmitButton.Show();
            ExportButton.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var filtered = transactions.Where(x => x.Account == account);

            if (selectedFilter == "Дата")
            {
                DateTime fromDate = FromDatePicker.Value;
                DateTime toDate = ToDatePicker.Value;
                filtered = filtered.Where(x => x.Date >= fromDate && x.Date <= toDate);

                AuditLog.Log(customer, $"Филтриране на транзакциите по дата за {account}");
            }
            else if (selectedFilter == "Сума")
            {
                bool isFromAmountValid = double.TryParse(FromAmountInput.Text, out double fromAmount);
                bool isToAmountValid = double.TryParse(ToAmountInput.Text, out double toAmount);
                if (!isFromAmountValid || !isToAmountValid || fromAmount > toAmount)
                {
                    _ = PrintMessage("Въведете валидна сума");
                    return;
                }

                filtered = filtered.Where(x => x.Amount >= fromAmount && x.Amount <= toAmount);

                AuditLog.Log(customer, $"Филтриране на транзакциите по сума({fromAmount}лв - {toAmount}лв) за {account}");
            }
            else if (selectedFilter == "Тип")
            {
                string? transactionType = TypeDropdown.SelectedItem as string;
                string type = transactionType switch
                {
                    "Внасяне" => "deposit",
                    "Изтегляне" => "withdraw",
                    "Плащане на кредит" => "loan payment",
                    "Прилагане на лихва" => "apply interest",
                    _ => ""
                };
                filtered = filtered.Where(x => x.Type == type);

                AuditLog.Log(customer, $"Филтриране на транзакциите по {transactionType} за {account}");
            }

            HistoryLabel.Text = Transaction.GetModifiedHistory(account, filtered.ToList());
            HistoryLabel.SelectAll();
            HistoryLabel.SelectionAlignment = HorizontalAlignment.Center;

            selectedFilter = "";
            FilterDropdown.SelectedIndex = -1;

            HideActionElements();
            ExportButton.Show();
        }

        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            HistoryLabel.Text = Transaction.GetHistory(account);
            HistoryLabel.SelectAll();
            HistoryLabel.SelectionAlignment = HorizontalAlignment.Center;

            HideActionElements();
            ResetActionElements();
            ExportButton.Show();

            FilterDropdown.SelectedIndex = -1;
            SortDropdown.SelectedIndex = -1;
            TypeDropdown.SelectedIndex = -1;
        }

        private void SortDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortDropdown.SelectedIndex == -1)
                return;

            var sorted = transactions.Where(x => x.Account == account);
            string? selectedItem = SortDropdown.SelectedItem as string;

            if (selectedItem == "Дата - възходяща")
            {
                sorted = sorted.OrderBy(x => x.Date);
                AuditLog.Log(customer, $"Сортиране на транзакциите по дата(възходяща) за {account}");
            }    
                
            else if (selectedItem == "Дата - низходяща")
            {
                sorted = sorted.OrderByDescending(x => x.Date);
                AuditLog.Log(customer, $"Сортиране на транзакциите по дата(низходяща) за {account}");
            }               

            else if (selectedItem == "Сума - възходяща")
            {
                sorted = sorted.OrderBy(x => x.Amount);
                AuditLog.Log(customer, $"Сортиране на транзакциите по сума(възходяща) за {account}");
            }               

            else if (selectedItem == "Сума - низходяща")
            {
                sorted = sorted.OrderByDescending(x => x.Amount);
                AuditLog.Log(customer, $"Сортиране на транзакциите по сума(низходяща) за {account}");
            }
                
            else if (selectedItem == "Тип")
            {
                sorted = sorted.OrderBy(x => x.Type);
                AuditLog.Log(customer, $"Сортиране на транзакциите по тип за {account}");
            }                

            HistoryLabel.Text = Transaction.GetModifiedHistory(account, sorted.ToList());
            HistoryLabel.SelectAll();
            HistoryLabel.SelectionAlignment = HorizontalAlignment.Center;

            HideActionElements();
            FilterDropdown.SelectedIndex = -1;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm(account);
            form.Show();
        }

        public void UpdateHistory()
        {
            HistoryLabel.Text = Transaction.GetHistory(account);
            HistoryLabel.SelectAll();
            HistoryLabel.SelectionAlignment = HorizontalAlignment.Center;
        }

        private async Task PrintMessage(string message)
        {
            MessageLabel.Text = message;
            await Task.Delay(1250);
            MessageLabel.Text = "";
        }

        private void HideActionElements()
        {
            FromLabel.Hide();
            ToLabel.Hide();
            FromAmountInput.Hide();
            ToAmountInput.Hide();
            FromDatePicker.Hide();
            ToDatePicker.Hide();
            TypeLabel.Hide();
            TypeDropdown.Hide();
            SubmitButton.Hide();
        }

        private void ResetActionElements()
        {
            FromDatePicker.Value = DateTime.Today;
            ToDatePicker.Value = DateTime.Today;
            FromAmountInput.Text = "";
            ToAmountInput.Text = "";
        }
    }
}
