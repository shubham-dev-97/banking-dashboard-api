using BankingDashAPI.Data;
using BankingDashAPI.Models;
using Microsoft.EntityFrameworkCore;
using BankingDashAPI.Models.Entities;

namespace BankingDashAPI.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly AppDbContext _context;

        public DashboardService(AppDbContext context)
        {
            _context = context;
        }

        // MAIN DASHBOARD
     
        public async Task<DashboardData> GetDashboardDataAsync()
        {
            return new DashboardData
            {
                FinancialSummary = await GetSummaryAsync(),
                LoanAnalyses = await GetLoanAnalysisAsync(),
                DepositAnalyses = await GetDepositAnalysisAsync(),
                MonthlyTransactions = await GetMonthlyTransactionsAsync()
            };
        }

       
        // LOANS
      
        public async Task<List<LoanAnalysis>> GetLoanAnalysisAsync()
        {
            return await _context.Loans
                .Select(x => new LoanAnalysis
                {
                    LoanType = x.LoanType,
                    Amount = x.Amount,
                    InterestRate = x.InterestRate,
                    Outstanding = x.Outstanding,
                    Status = x.Status
                })
                .ToListAsync();
        }

        
        // DEPOSITS
        
        public async Task<List<DepositAnalysis>> GetDepositAnalysisAsync()
        {
            

            return await _context.Deposits
          .GroupBy(x => x.AccountType)
           .Select(g => new DepositAnalysis
         {
            AccountType = g.Key,
            Balance = g.Sum(x => x.Balance),
            InterestRate = g.Average(x => x.InterestRate)
          })
            .ToListAsync();
          }

        // FINANCIAL SUMMARY
     
        public async Task<FinancialSummary> GetSummaryAsync()
        {
            var totalLoans = await _context.Loans.SumAsync(x => x.Outstanding);
            var totalDeposits = await _context.Deposits.SumAsync(x => x.Balance);

            return new FinancialSummary
            {
                TotalAssets = totalDeposits,
                TotalLiabilities = totalLoans,
                NetWorth = totalDeposits - totalLoans,
                TotalLoans = totalLoans,
                TotalDeposits = totalDeposits,
                MonthlyRevenue = 0,
                ProfitMargin = 0
            };
        }

        // MONTHLY TRANSACTIONS

        //private async Task<List<MonthlyTransaction>> GetMonthlyTransactionsAsync()
        //{
        //    return await _context.Transactions
        //        .GroupBy(t => t.Date.Month)
        //        .Select(g => new MonthlyTransaction
        //        {
        //            Month = new DateTime(1, g.Key, 1).ToString("MMM"),

        //            Deposits = g.Where(x => x.Type == "Deposit").Sum(x => x.Amount),
        //            Withdrawals = g.Where(x => x.Type == "Withdrawal").Sum(x => x.Amount),
        //            Transfers = g.Where(x => x.Type == "Transfer").Sum(x => x.Amount)
        //        })
        //        .OrderBy(x => x.Month)
        //        .ToListAsync();
        //}


        private async Task<List<MonthlyTransaction>> GetMonthlyTransactionsAsync()
        {
            var data = await _context.Transactions
                .GroupBy(t => t.Date.Month)
                .Select(g => new
                {
                    MonthNumber = g.Key,
                    Deposits = g.Where(x => x.Type == "Deposit").Sum(x => x.Amount),
                    Withdrawals = g.Where(x => x.Type == "Withdrawal").Sum(x => x.Amount),
                    Transfers = g.Where(x => x.Type == "Transfer").Sum(x => x.Amount)
                })
                .ToListAsync(); // EXECUTE SQL FIRST

            //  Convert in memory 
            return data.Select(x => new MonthlyTransaction
            {
                Month = new DateTime(1, x.MonthNumber, 1).ToString("MMM"),
                Deposits = x.Deposits,
                Withdrawals = x.Withdrawals,
                Transfers = x.Transfers
            }).ToList();
        }

    }
}
