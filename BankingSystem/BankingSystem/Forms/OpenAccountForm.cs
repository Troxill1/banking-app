using BankingSystem.Core;
using BankingSystem.Core.BankAccounts;

namespace BankingSystem
{
    public partial class OpenAccountForm : Form
    {
        Customer customer;
        BankAccount? account;

        public OpenAccountForm(Customer customer)
        {
            InitializeComponent();

            AmountLabel.Hide();
            AmountTextBox.Hide();
            PeriodLabel.Hide();
            PeriodTextBox.Hide();
            SubmitButton.Hide();

            this.customer = customer;
        }

        private void LoanButton_Click(object sender, EventArgs e)
        {
            LoanButton.Hide();
            SavingsButton.Hide();
            CheckingButton.Hide();

            AmountLabel.Show();
            AmountTextBox.Show();
            PeriodLabel.Show();
            PeriodTextBox.Show();
            SubmitButton.Show();
        }

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            CreateAccount("savings");
        }

        private void CheckingButton_Click(object sender, EventArgs e)
        {
            CreateAccount("checking");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isLoanValid = double.TryParse(AmountTextBox.Text, out double loan);
            bool isPeriodValid = byte.TryParse(PeriodTextBox.Text, out byte period);

            if (!isLoanValid || loan < 5000 || loan > 150000)
                MessageLabel.Text = "Въведете сума между 5000лв и 150 000лв";
            else if (!isPeriodValid || period < 1 || period > 5)
                MessageLabel.Text = "Въведете период между 1 и 5 години";
            else
                CreateAccount("loan", loan, (byte)(period * 12));
        }

        private void CreateAccount(string accountType, double loan = 0, byte period = 12)
        {
            if (loan == 0)
                account = customer.OpenAccount(accountType);
            else
                account = customer.OpenAccount(accountType, loan, period);

            AuditLog.Log(customer, $"Откриване на {account}");

            Hide();
            MainMenuForm form = new MainMenuForm(customer, account);
            form.Show();
        }
    }
}
