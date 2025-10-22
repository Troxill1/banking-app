namespace BankingSystem.Core.BankAccounts
{
    public class LoanAccount : BankAccount
    {
        private double LoanAmount { get; set; }
        private double InterestRate { get; set; }
        public byte LoanPeriod { get; private set; } // In months
        public double EMI { get; private set; } // Equated monthly installment
        public byte PaidEMIs { get; private set; }
        public double RemainingLoan { get; private set; }

        public LoanAccount(string holderName, double loanAmount, byte loanPeriod) : base(holderName)
        {
            LoanPeriod = loanPeriod;
            InterestRate = DetermineInterestRate();
            LoanAmount = loanAmount;
            EMI = CalculateEMI();
            RemainingLoan = EMI * LoanPeriod;
            PaidEMIs = 0;
        }

        public bool MakePayment(double amount)
        {
            if (RemainingLoan <= 0 || amount <= 0 || amount > RemainingLoan)
                return false;

            while (amount >= EMI)
            {
                RemainingLoan -= EMI;
                PaidEMIs++;
                amount -= EMI;
                EMI = CalculateEMI();
            }             

            EMI = Math.Round(EMI - amount, 2);
            RemainingLoan = Math.Round(RemainingLoan - amount, 2);

            if (EMI == 0)
            {
                PaidEMIs++;
                EMI = CalculateEMI();
            }
            
            if (PaidEMIs == LoanPeriod)
            {
                RemainingLoan = 0;
                EMI = 0;
            }      

            return true;
        }

        public double CalculateEMI() // Based on the Reducing Balance Method
        {
            double monthlyRate = InterestRate / LoanPeriod / 100;
            double emi = LoanAmount * monthlyRate * Math.Pow(1 + monthlyRate, LoanPeriod) /
                (Math.Pow(1 + monthlyRate, LoanPeriod) - 1);
            return Math.Round(emi, 2);
        }
        
        private double DetermineInterestRate()
        {
            if (LoanAmount <= 10000)
                return 5.0;
            else if (LoanAmount <= 50000)
                return 7.5;
            else
                return 10.0;
        }

        public override string ToString() => $"Кредитна сметка: {AccountNumber}";
    }
}
