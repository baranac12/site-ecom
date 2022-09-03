using Microsoft.AspNetCore.Mvc;

namespace eticaret.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
