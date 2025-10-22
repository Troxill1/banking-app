using BankingSystem.Core.BankAccounts;

namespace BankingSystem.Core
{
    public class Customer
    {
        public static List<Customer> customers = new List<Customer>();
        
        public string Name { get; private set; }
        private string HashedPassword { get; set; }
        private string Address { get; set; }
        public string PhoneNumber { get; private set; }
        public List<BankAccount> Accounts { get; private set; }

        public Customer(string name, string password, string address, string phoneNumber)
        {
            Name = name;
            HashedPassword = PasswordUtils.Hash(password);
            Address = address;
            PhoneNumber = phoneNumber;
            Accounts = new List<BankAccount>();
            customers.Add(this);
        }

        public BankAccount OpenAccount(string accountType, double loanAmount = 0, byte loanPeriod = 12)
        {
            BankAccount account;
            if (accountType == "checking")
                account = new CheckingAccount(Name);
            else if (accountType == "savings")
                account = new SavingsAccount(Name);
            else if (accountType == "loan")
                account = new LoanAccount(Name, loanAmount, loanPeriod);
            else
                throw new ArgumentException($"Invalid bank account type - {accountType}");

            Accounts.Add(account);
            return account;
        }

        public static string ValidateInput(string name, string password, string phone, string address)
        {
            string message = "";
            bool isPhoneOnlyDigits = long.TryParse(phone, out long temp);

            if (phone.Length != 10 || !isPhoneOnlyDigits)
                message = "Въведете валиден телефонен номер, започващ с 0";

            else if (customers.Contains(customers.FirstOrDefault(x => x.PhoneNumber == phone)!))
                message = "Вече съществува акаунт с този тел. номер";

            else if (name.Split(' ').Length != 2 || name.Length < 8)
                message = "Въведете собствено и фамилно име напълно";

            else if (password.Length < 10)
                message = "Въведете парола с поне десет символа";

            else if (address.Length < 20)
                message = "Въведете пълен адрес (град/село, ж.к., улица)";

            return message;
        }

        public static string ValidateInput(string phone, string password)
        {
            string message = "";
            bool isPhoneOnlyDigits = long.TryParse(phone, out long temp);

            if (!isPhoneOnlyDigits || !customers.Contains(customers.FirstOrDefault(x => x.PhoneNumber == phone)!))
                message = "Не съществува акаунт с този тел. номер";
            else
            {
                Customer customer = customers.First(x => x.PhoneNumber == phone);
                if (!customer.VerifyPassword(password))
                    message = "Грешна парола";
            }

            return message;
        }

        private bool VerifyPassword(string inputPassword) => PasswordUtils.Verify(HashedPassword, inputPassword);

        /*public bool CloseAccount(string accountNumber)
        {
            if (Accounts.Any(x => x.AccountNumber == accountNumber))
            {
                BankAccount toClose = Accounts.First(x => x.AccountNumber == accountNumber);
                Accounts.Remove(toClose);
                return true;                
            }

            return false;          
        }*/
    }
}
