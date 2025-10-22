namespace BankingSystem.Core.BankAccounts
{
    class CheckingAccount : BankAccount
    {
        private double overdraftLimit = 200;

        public CheckingAccount(string holderName) : base(holderName)
        {
        }

        public override bool Withdraw(double amount) // add tax?
        {
            if (Balance + overdraftLimit < amount)
                return false;

            Balance -= amount;
            return true;
        }

        public override string GetBalance() => $"{Balance:N2}лв\nОвърдрафт лимит: {overdraftLimit}";

        public override string ToString() => $"Разплащателна сметка: {AccountNumber}";
    }
}
