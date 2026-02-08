using BankingDashAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingDashAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetDashboardData()
        {
            var data = await _dashboardService.GetDashboardDataAsync();
            return Ok(data);
        }

        [HttpGet("loans")]
        public async Task<IActionResult> GetLoanAnalysis()
        {
            var loans = await _dashboardService.GetLoanAnalysisAsync();
            return Ok(loans);
        }

        [HttpGet("deposits")]
        public async Task<IActionResult> GetDepositAnalysis()
        {
            var deposits = await _dashboardService.GetDepositAnalysisAsync();
            return Ok(deposits);
        }

        [HttpGet("summary")]
        public async Task<IActionResult> GetSummary()
        {
            var summary = await _dashboardService.GetSummaryAsync();
            return Ok(summary);
        }
    }
}
