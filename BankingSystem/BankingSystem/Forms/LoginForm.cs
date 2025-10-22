using BankingSystem.Core;

namespace BankingSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string phone = PhoneInput.Text.Trim();
            string password = PasswordInput.Text.Trim(); 

            string message = Customer.ValidateInput(phone, password);
            if (message != "")
            {
                MessageLabel.Text = message;
                return;
            }

            

            Customer customer = Customer.customers.First(x => x.PhoneNumber == phone);
            AuditLog.Log(customer, "Влизане в профил");
            var account = customer.Accounts.First();

            Hide();
            var form = new MainMenuForm(customer, account);
            form.Show(); 
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }
    }
}
