using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;

namespace ShopMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(SampleData.Categories);
        }
    }
}
