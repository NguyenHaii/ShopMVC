using ShopMVC.Models;
using System.Collections.Generic;

namespace ShopMVC.Data
{
    public static class SampleData
    {
        public static List<Category> Categories = new()
        {
            new Category { Id = 1, Name = "Điện thoại" },
            new Category { Id = 2, Name = "Laptop" }
        };

        public static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "iPhone 8", Price = 10000000, ImageUrl = "/images/iphone8.jpg", Description = "iPhone 8 - thiết kế cổ điển, hiệu năng ổn.", CategoryId = 1 },
            new Product { Id = 2, Name = "iPhone X", Price = 12000000, ImageUrl = "/images/iphone10.jpg", Description = "iPhone X - màn hình tai thỏ.", CategoryId = 1 },
            new Product { Id = 3, Name = "Android Phone", Price = 8000000, ImageUrl = "/images/android.jpg", Description = "Điện thoại Android phổ thông.", CategoryId = 1 },
            new Product { Id = 4, Name = "Samsung Galaxy", Price = 18000000, ImageUrl = "/images/samsung.jpg", Description = "Samsung Galaxy - hiển thị đẹp, camera tốt.", CategoryId = 1 },
            new Product { Id = 5, Name = "iPhone 14", Price = 25000000, ImageUrl = "/images/iphone14.jpg", Description = "iPhone 14 - bản mới nhất.", CategoryId = 1 },

            new Product { Id = 6, Name = "MacBook M1", Price = 30000000, ImageUrl = "/images/m1.jpg", Description = "MacBook M1 - hiệu năng tốt, pin lâu.", CategoryId = 2 },
            new Product { Id = 7, Name = "MacBook M2", Price = 40000000, ImageUrl = "/images/m2.jpg", Description = "MacBook M2 - nhanh hơn M1.", CategoryId = 2 },
            new Product { Id = 8, Name = "MacBook Air", Price = 25000000, ImageUrl = "/images/m3.jpg", Description = "MacBook Air - nhẹ, mỏng.", CategoryId = 2 },
            new Product { Id = 9, Name = "MacBook Pro", Price = 45000000, ImageUrl = "/images/m4.jpg", Description = "MacBook Pro - hiệu suất cao.", CategoryId = 2 }
        };
    }
}
