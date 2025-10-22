using BankingSystem.Core;

namespace BankingSystem.Forms
{
    public partial class AuditLogForm : Form
    {
        private MainMenuForm sender;
        private Customer customer;

        public AuditLogForm(MainMenuForm sender, Customer customer)
        {
            InitializeComponent();

            this.sender = sender;
            this.customer = customer;

            NameLabel.Text = customer.Name;

            DisplayLogs();
            AuditLog.Log(customer, "Преглед на записите на потребителски операции");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AuditLog.ClearLogs(customer);
            DisplayLogs();
            AuditLog.Log(customer, "Премахване на записите на потребителски операции");
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
            this.sender.Show();
        }

        private void DisplayLogs()
        {
            LogLabel.Text = AuditLog.GetLogs(customer);           
        }
    }
}
