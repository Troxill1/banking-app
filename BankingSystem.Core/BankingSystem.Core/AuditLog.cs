namespace BankingSystem.Core
{
    public class AuditLog
    {
        private static List<AuditLog> logs = new();

        private Customer? Customer { get; set; }
        private string? Action { get; set; }
        private DateTime Timestamp { get; set; }

        private AuditLog(Customer customer, string action)
        {
            Customer = customer;
            Action = action;
            Timestamp = DateTime.Now;
        }

        public static void Log(Customer customer, string action)
        {
            logs.Add(new AuditLog(customer, action));
        }

        public static string GetLogs(Customer customer)
        {
            var customerLogs = logs
                .Where(x => x.Customer == customer)
                .OrderBy(x => x.Timestamp)
                .Select(x => x.ToString());

            return customerLogs.Any()
                ? string.Join("\n", customerLogs)
                : "Няма налични записи на потребителски операции";
        }

        public static void ClearLogs(Customer customer)
        {
            logs.RemoveAll(x => x.Customer == customer);
        }

        public override string ToString()
        {
            return $"[{Timestamp:G}] {Action}";
        }
    }
}
