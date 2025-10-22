using BankingSystem.Forms;
using BankingSystem.Core;

namespace BankingSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = NameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
            string phone = PhoneInput.Text.Trim();
            string address = AddressInput.Text.Trim();

            string message = Customer.ValidateInput(name, password, phone, address);
            if (message != "")
            {
                MessageLabel.Text = message;
                return;
            }

            Customer customer = new Customer(name, password, address, phone);
            AuditLog.Log(customer, "Регистрация на профил");

            Hide();
            OpenAccountForm form = new OpenAccountForm(customer);
            form.Show();
        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
