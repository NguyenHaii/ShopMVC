using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;
using System.Linq;

namespace ShopMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Category(int id)
        {
            var products = SampleData.Products.Where(p => p.CategoryId == id).ToList();
            ViewBag.CategoryName = SampleData.Categories.FirstOrDefault(c => c.Id == id)?.Name ?? "Sản phẩm";
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = SampleData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        public IActionResult Index()
        {
            var products = SampleData.Products.ToList();
            return View(products);
        }
    }
}
