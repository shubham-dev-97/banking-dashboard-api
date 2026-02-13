namespace BankingDashAPI.Models.Entities
{
    public class Deposit
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
    }
}
