namespace BankingDashAPI.Models.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public decimal Amount { get; set; }
        public string Type { get; set; } // Deposit/Withdrawal/Transfer
        public DateTime Date { get; set; }
    }
}
