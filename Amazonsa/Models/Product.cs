using System.ComponentModel.DataAnnotations;

namespace amazonsa.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot be longer than 50 characters")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be a non-negative number")]
        public int StockQuantity { get; set; }
    }
}
