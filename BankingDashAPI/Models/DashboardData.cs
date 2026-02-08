namespace BankingDashAPI.Models
{
    public class DashboardData
    {
        public FinancialSummary FinancialSummary { get; set; }
        public List<LoanAnalysis> LoanAnalyses { get; set; }
        public List<DepositAnalysis> DepositAnalyses { get; set; }
        public List<MonthlyTransaction> MonthlyTransactions { get; set; }
    }
    public class FinancialSummary
    {
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal NetWorth { get; set; }
        public decimal TotalLoans { get; set; }
        public decimal TotalDeposits { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public decimal ProfitMargin { get; set; }
    }

   


    public class MonthlyTransaction
    {
        public string Month { get; set; }
        public decimal Deposits { get; set; }
        public decimal Withdrawals { get; set; }
        public decimal Transfers { get; set; }
    }
}
