using BankingDashAPI.Models;

namespace BankingDashAPI.Services
{
    public class DashboardService : IDashboardService
    {
        public async Task<DashboardData> GetDashboardDataAsync()
        {
            // Mock data - in real app, this would come from database
            return await Task.FromResult(new DashboardData
            {
                FinancialSummary = GetFinancialSummary(),
                LoanAnalyses = GetLoanAnalysisData(),
                DepositAnalyses = GetDepositAnalysisData(),
                MonthlyTransactions = GetMonthlyTransactions()
            });
        }

        public async Task<List<LoanAnalysis>> GetLoanAnalysisAsync()
        {
            return await Task.FromResult(GetLoanAnalysisData());
        }

        public async Task<List<DepositAnalysis>> GetDepositAnalysisAsync()
        {
            return await Task.FromResult(GetDepositAnalysisData());
        }

        public async Task<FinancialSummary> GetSummaryAsync()
        {
            return await Task.FromResult(GetFinancialSummary());
        }

        private FinancialSummary GetFinancialSummary()
        {
            return new FinancialSummary
            {
                TotalAssets = 12500000,
                TotalLiabilities = 4500000,
                NetWorth = 8000000,
                TotalLoans = 3200000,
                TotalDeposits = 8500000,
                MonthlyRevenue = 450000,
                ProfitMargin = 28.5m
            };
        }

        private List<LoanAnalysis> GetLoanAnalysisData()
        {
            return new List<LoanAnalysis>
            {
                new LoanAnalysis { LoanType = "Home Loan", Amount = 500000, InterestRate = 4.5m, Outstanding = 450000, Status = "Active", Month = 1 },
                new LoanAnalysis { LoanType = "Personal Loan", Amount = 50000, InterestRate = 8.5m, Outstanding = 25000, Status = "Active", Month = 2 },
                new LoanAnalysis { LoanType = "Business Loan", Amount = 200000, InterestRate = 6.2m, Outstanding = 150000, Status = "Active", Month = 3 },
                new LoanAnalysis { LoanType = "Auto Loan", Amount = 30000, InterestRate = 5.8m, Outstanding = 10000, Status = "Active", Month = 4 },
                new LoanAnalysis { LoanType = "Education Loan", Amount = 40000, InterestRate = 4.0m, Outstanding = 30000, Status = "Active", Month = 5 }
            };
        }

        private List<DepositAnalysis> GetDepositAnalysisData()
        {
            return new List<DepositAnalysis>
            {
                new DepositAnalysis { AccountType = "Savings", Balance = 250000, InterestRate = 2.5m, MonthlyGrowth = 2.1m, Month = 1 },
                new DepositAnalysis { AccountType = "Current", Balance = 500000, InterestRate = 1.5m, MonthlyGrowth = 1.2m, Month = 2 },
                new DepositAnalysis { AccountType = "Fixed Deposit", Balance = 750000, InterestRate = 5.5m, MonthlyGrowth = 0.8m, Month = 3 },
                new DepositAnalysis { AccountType = "Recurring Deposit", Balance = 100000, InterestRate = 4.2m, MonthlyGrowth = 1.5m, Month = 4 },
                new DepositAnalysis { AccountType = "Corporate", Balance = 2000000, InterestRate = 3.2m, MonthlyGrowth = 3.1m, Month = 5 }
            };
        }

        private List<MonthlyTransaction> GetMonthlyTransactions()
        {
            return new List<MonthlyTransaction>
            {
                new MonthlyTransaction { Month = "Jan", Deposits = 1200000, Withdrawals = 800000, Transfers = 400000 },
                new MonthlyTransaction { Month = "Feb", Deposits = 1400000, Withdrawals = 900000, Transfers = 500000 },
                new MonthlyTransaction { Month = "Mar", Deposits = 1600000, Withdrawals = 1000000, Transfers = 600000 },
                new MonthlyTransaction { Month = "Apr", Deposits = 1800000, Withdrawals = 1100000, Transfers = 700000 },
                new MonthlyTransaction { Month = "May", Deposits = 2000000, Withdrawals = 1200000, Transfers = 800000 }
            };
        }
    }
}
