using Microsoft.AspNetCore.Mvc;

namespace eticaret.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
