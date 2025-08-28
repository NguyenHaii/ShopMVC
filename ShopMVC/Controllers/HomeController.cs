using Microsoft.AspNetCore.Mvc;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Điện thoại" },
                new Category { Id = 2, Name = "Laptop" }
            };

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 8", ImageUrl = "/images/iphone8.jpg", Price = 8000000, CategoryId = 1 },
                new Product { Id = 2, Name = "iPhone 10", ImageUrl = "/images/iphone10.jpg", Price = 12000000, CategoryId = 1 },
                new Product { Id = 3, Name = "Android", ImageUrl = "/images/android.jpg", Price = 7000000, CategoryId = 1 },
                new Product { Id = 4, Name = "Samsung Galaxy", ImageUrl = "/images/samsung.jpg", Price = 10000000, CategoryId = 1 },
                new Product { Id = 5, Name = "M1", ImageUrl = "/images/m1.jpg", Price = 20000000, CategoryId = 2 },
                new Product { Id = 6, Name = "M2", ImageUrl = "/images/m2.jpg", Price = 25000000, CategoryId = 2 },
                new Product { Id = 7, Name = "M3", ImageUrl = "/images/m3.jpg", Price = 27000000, CategoryId = 2 },
                new Product { Id = 8, Name = "M4", ImageUrl = "/images/m4.jpg", Price = 30000000, CategoryId = 2 }
            };

            ViewBag.Categories = categories;
            ViewBag.Products = products;

            return View();
        }
    }
}
