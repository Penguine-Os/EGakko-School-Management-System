using Microsoft.AspNetCore.Mvc;

namespace EGakko_Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
