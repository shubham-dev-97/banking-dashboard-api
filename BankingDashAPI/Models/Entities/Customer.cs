namespace BankingDashAPI.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Loan> Loans { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
    }
}
