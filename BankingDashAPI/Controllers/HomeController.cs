using Microsoft.AspNetCore.Mvc;

namespace BankingDashAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
