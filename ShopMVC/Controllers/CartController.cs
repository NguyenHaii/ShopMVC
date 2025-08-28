using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;

namespace ShopMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ProductsJson = System.Text.Json.JsonSerializer.Serialize(SampleData.Products);
            return View();
        }
    }
}
