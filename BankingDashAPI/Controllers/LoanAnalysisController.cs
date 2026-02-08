using BankingDashAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankingDashAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoanAnalysisController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Dummy data
            var loanAnalysis = new List<LoanAnalysis>
            {
                new LoanAnalysis { Month = 1, LoanAmount = 100000, Interest = 5000 },
                new LoanAnalysis { Month = 2, LoanAmount = 150000, Interest = 7500 },
                new LoanAnalysis { Month = 3, LoanAmount = 200000, Interest = 10000 },
                new LoanAnalysis { Month = 4, LoanAmount = 250000, Interest = 12500 },
                new LoanAnalysis { Month = 5, LoanAmount = 300000, Interest = 15000 },
            };

            return Ok(loanAnalysis);
        }
    }
}
