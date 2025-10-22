namespace BankingSystem.Core.BankAccounts
{
    public class SavingsAccount : BankAccount
    {
        public readonly double interestRate = 0.035;

        public SavingsAccount(string holderName) : base(holderName)
        {
        }

        public override bool Withdraw(double amount) //add tax?
        {
            if (Balance < amount)
                return false;

            Balance -= amount;
            return true;
        }

        public double ApplyInterest()
        {
            double interest = Balance * interestRate;
            Deposit(interest);
            return interest;
        }

        public override string ToString() => $"Спестовна сметка: {AccountNumber}";
    }
}
