using Microsoft.AspNetCore.Mvc;

namespace BankingDashAPI.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
