namespace BankingSystem.Core.BankAccounts
{
    public class BankAccount
    {
        private static List<BankAccount> accounts = new List<BankAccount>();

        public string AccountNumber { get; private set; }
        public string HolderName { get; private set; }
        protected double Balance { get; set; }

        public BankAccount(string holderName)
        {
            HolderName = holderName;
            AccountNumber = GenerateAccountNumber(HolderName);
            Balance = 0;
            accounts.Add(this);
        }

        public void Deposit(double amount) => Balance += amount; //add tax?

        public virtual bool Withdraw(double amount) //add tax?
        {
            if (Balance < amount)
                return false;

            Balance -= amount;
            return true;
        }

        public virtual string GetBalance() => $"{Balance:N2}";

        private string GenerateAccountNumber(string holderName)
        {
            string[] names = holderName.Split(' ');
            string initials = $"{names[0][0]}{names[1][0]}";

            string accountNumber;
            Random rnd = new Random();

            do
            {
                string serialNumber = $"{rnd.Next(100000, 999999)}";
                accountNumber = initials + serialNumber;
            } while (accounts.Any(x => x.AccountNumber == accountNumber));

            return accountNumber;
        }
    }
}
