using amazonsa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace amazonsa.Controllers
{
    
    public class ProductController : Controller
    {
        
        public static List<Product> Products = new List<Product>
{
    new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1500, StockQuantity = 10 },
    new Product { ProductID = 2, Name = "Smartphone", Category = "Electronics", Price = 999, StockQuantity = 20 },
    new Product { ProductID = 3, Name = "T-Shirt", Category = "Clothing", Price = 50, StockQuantity = 30 }
};


       
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index", Products);
        }
    }
}
