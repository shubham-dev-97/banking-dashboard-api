using BankingDashAPI.Models;

namespace BankingDashAPI.Services
{
    public interface IDashboardService
    {
        Task<DashboardData> GetDashboardDataAsync();
        Task<List<LoanAnalysis>> GetLoanAnalysisAsync();
        Task<List<DepositAnalysis>> GetDepositAnalysisAsync();
        Task<FinancialSummary> GetSummaryAsync();

        
    }
}
