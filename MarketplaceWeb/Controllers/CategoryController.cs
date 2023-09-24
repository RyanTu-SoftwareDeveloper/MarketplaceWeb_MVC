using Microsoft.AspNetCore.Mvc;

namespace MarketplaceWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
