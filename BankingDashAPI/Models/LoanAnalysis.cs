namespace BankingDashAPI.Models
{
    public class LoanAnalysis
    {
        public int Month { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal Interest { get; set; }
        public string LoanType { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Outstanding { get; set; }
        public string Status { get; set; }
    }
}
