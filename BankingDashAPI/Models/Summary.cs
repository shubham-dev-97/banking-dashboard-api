namespace BankingDashAPI.Models
{
    public class Summary
    {
        public int TotalLoans { get; set; }
        public decimal TotalLoanAmount { get; set; }
        public int TotalDeposits { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public decimal TotalInterest { get; set; }
    }
}
