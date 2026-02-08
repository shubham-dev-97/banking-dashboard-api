using Microsoft.AspNetCore.Mvc;

namespace BankingDashAPI.Controllers
{
    public class DepositAnalysisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
