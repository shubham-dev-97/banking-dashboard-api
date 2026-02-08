namespace BankingDashAPI.Models
{

    public class DepositAnalysis
    {
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyGrowth { get; set; }
        public int Month { get; set; }
    }
}
