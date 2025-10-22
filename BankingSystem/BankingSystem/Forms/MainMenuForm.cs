using BankingSystem.Core;
using BankingSystem.Core.BankAccounts;
using BankingSystem.Forms;
using BankingSystem.Core.Operations;

namespace BankingSystem
{
    public partial class MainMenuForm : Form
    {
        private Customer customer;
        private BankAccount account;
        private Dictionary<string, IAccountOperation> operations;
        private TransactionHistoryForm? transactionForm;

        public MainMenuForm(Customer customer, BankAccount account)
        {
            InitializeComponent();

            this.customer = customer;
            this.account = account;

            operations = new Dictionary<string, IAccountOperation>();
            InitializeOperations();

            HideSubmitElements();
            HelloLabel.Text = "Здравей, " + customer.Name;
            AccountLabel.Text = account.ToString();

            AccountsDropdown.Items.Clear();
            foreach (var acc in customer.Accounts)
            {
                if (acc.AccountNumber != account.AccountNumber)
                    AccountsDropdown.Items.Add(acc);
            }
            AccountsDropdown.Items.Add("Нова сметка");

            if (account is LoanAccount loanAccount)
            {
                WithdrawButton.Hide();
                DepositButton.Text = "Плати EMI";
            }
            else
            {
                EmiLabel.Hide();

                if (account is SavingsAccount)
                {
                    CancellationTokenSource interestSource = new CancellationTokenSource();
                    CancellationToken token = interestSource.Token;
                    Task interestTask = StartInterestTimer(token);
                }
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            HideActionButtons();
            AmountLabel.Show();
            AmountInput.Show();
            SubmitDepositButton.Show();
            ReturnButton.Show();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            HideActionButtons();
            AmountLabel.Show();
            AmountInput.Show();
            SubmitWithdrawButton.Show();
            ReturnButton.Show();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (transactionForm == null)
                transactionForm = new TransactionHistoryForm(this, account);
            else
                transactionForm.UpdateHistory();

            transactionForm.Show();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuditLogForm form = new(this, customer);
            form.Show();
        }

        private async void SubmitDepositButton_Click(object sender, EventArgs e)
        {
            bool isAmountValid = double.TryParse(AmountInput.Text, out double amount);
            if (!isAmountValid)
            {
                MessageLabel.Text = $"Въведете валидна сума";
                MessageLabel.ForeColor = Color.Red;

                await Task.Delay(1250);
                MessageLabel.Text = "";

                return;
            }

            if (account is LoanAccount)
            {
                bool paymentStatus = operations["loan payment"].Execute(account, amount);
                if (paymentStatus)
                {
                    ShowActionButtons();
                    HideSubmitElements();

                    MessageLabel.Text = $"Успешно заплатихте {amount}лв за EMI";
                    MessageLabel.ForeColor = Color.Green;
                }
                else
                {
                    MessageLabel.Text = $"Неуспешно плащане. Въведете сума между 0 и оставащия кредит";
                    MessageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                operations["deposit"].Execute(account, amount);

                ShowActionButtons();
                HideSubmitElements();

                MessageLabel.Text = $"Успешно внесохте {amount}лв";
                MessageLabel.ForeColor = Color.Green;
            }

            await Task.Delay(3000);
            MessageLabel.Text = "";
        }

        private async void SubmitWithdrawButton_Click(object sender, EventArgs e)
        {
            bool isAmountValid = double.TryParse(AmountInput.Text, out double amount);
            if (!isAmountValid)
            {
                MessageLabel.Text = $"Въведете валидна сума";
                MessageLabel.ForeColor = Color.Red;

                await Task.Delay(1250);
                MessageLabel.Text = "";

                return;
            }

            if (operations["withdraw"].Execute(account, amount))
            {
                ShowActionButtons();
                HideSubmitElements();

                MessageLabel.Text = $"Успешно изтеглихте {amount}лв";
                MessageLabel.ForeColor = Color.Green;
            }
            else
            {
                ShowActionButtons();
                HideSubmitElements();

                MessageLabel.Text = $"Недостатъчна наличност";
                MessageLabel.ForeColor = Color.Red;
            }

            await Task.Delay(3000);
            MessageLabel.Text = "";
        }

        private void AccountsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedItem = AccountsDropdown.SelectedItem!.ToString();
            if (selectedItem == "Нова сметка")
            {
                Hide();
                OpenAccountForm form = new OpenAccountForm(customer);
                form.Show();
            }
            else
            {
                string[] item = selectedItem!.Split(" ");
                string accountNumber = item[2];
                BankAccount account = customer.Accounts.First(x => x.AccountNumber == accountNumber);

                AuditLog.Log(customer, $"Превключване към {account}");

                Hide();
                MainMenuForm form = new MainMenuForm(customer, account);
                form.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ShowActionButtons();
            HideSubmitElements();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AuditLog.Log(customer, $"Излизане от профил");

            Hide();
            var form = new LoginForm();
            form.Show();
        }

        private void HideActionButtons()
        {
            DepositButton.Hide();
            WithdrawButton.Hide();
            HistoryButton.Hide();
        }

        private void HideSubmitElements()
        {
            AmountLabel.Hide();
            AmountInput.Hide();
            SubmitDepositButton.Hide();
            SubmitWithdrawButton.Hide();
            ReturnButton.Hide();

            AmountInput.Text = "";
            if (this.account is LoanAccount account)
            {
                BalanceLabel.Text = $"Оставащ кредит: {account.RemainingLoan:N}лв" +
                    $"\nИзлатени месеци: {account.PaidEMIs}/{account.LoanPeriod}";
                EmiLabel.Text = $"Оставащ EMI: {account.EMI:N}лв";
            }
            else
                BalanceLabel.Text = $"Наличност: {this.account.GetBalance()}лв";
        }

        private void ShowActionButtons()
        {
            DepositButton.Show();
            HistoryButton.Show();

            if (account is not LoanAccount)
                WithdrawButton.Show();
        }

        private async Task StartInterestTimer(CancellationToken token)
        {
            if (this.account is SavingsAccount account)
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(TimeSpan.FromSeconds(10));
                    operations["apply interest"].Execute(account, 0);

                    double interestRate = account.interestRate * 100;

                    MessageLabel.ForeColor = Color.Green;
                    MessageLabel.Text = $"Лихва от {interestRate:N2}% е приложена";
                    BalanceLabel.Text = $"Наличност: {account.GetBalance()}лв";

                    if (transactionForm != null && transactionForm.Visible)
                        transactionForm.UpdateHistory();

                    await Task.Delay(3000);
                    MessageLabel.Text = "";
                }
            }
        }

        private void InitializeOperations()
        {
            if (account is LoanAccount)
                operations["loan payment"] = new PayLoanOperation();
            else
            {
                operations["deposit"] = new DepositOperation();
                operations["withdraw"] = new WithdrawOperation();

                if (account is SavingsAccount)
                    operations["apply interest"] = new ApplyInterestOperation();
            }
        }
    }
}
