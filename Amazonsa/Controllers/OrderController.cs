using amazonsa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace amazonsa.Controllers
{
    [Route("Orders")]
    public class OrderController : Controller
    {
        public static List<User> Users = new List<User>
        {
            new User { UserID = 1, UserName = "Osama", Email = "osama@example.com" },
            new User { UserID = 2, UserName = "Abdallah", Email = "abdallah@example.com" }
        };

        public static List<Order> Orders = new List<Order>();

        [HttpGet("{userId}")]
        public IActionResult Index(int userId)
        {
            var user = Users.FirstOrDefault(u => u.UserID == userId);

            if (user == null)
                return NotFound("User not found.");

            var userOrders = Orders.Where(o => o.UserID == userId).ToList();
            user.Orders = userOrders;

            ViewBag.UserName = user.UserName;
            ViewBag.Email = user.Email;

            return View("Index", userOrders);
        }

        [HttpPost("Create")]
        public IActionResult CreateOrder(int userId, int productId, int quantity)
        {
            var product = ProductController.Products.FirstOrDefault(p => p.ProductID == productId);

            if (product == null || quantity <= 0)
                return BadRequest("Invalid product or quantity.");

            if (quantity > product.StockQuantity)
                return BadRequest("Insufficient stock.");

            var user = Users.FirstOrDefault(u => u.UserID == userId);
            if (user == null)
                return NotFound("User not found.");

            var orderDetail = new OrderDetails
            {
                ProductID = product.ProductID,
                Quantity = quantity,
                SubTotal = product.Price * quantity
            };

            var order = new Order
            {
                OrderID = Orders.Count + 1,
                UserID = user.UserID,
                User = user,
                OrderDate = DateTime.Now,
                OrderDetailsList = new List<OrderDetails> { orderDetail },
                TotalAmount = orderDetail.SubTotal
            };

            product.StockQuantity -= quantity;
            Orders.Add(order);

            return RedirectToAction("Index", new { userId = user.UserID });
        }
    }
}
