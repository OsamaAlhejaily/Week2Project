using System.ComponentModel.DataAnnotations;

namespace amazonsa.Models
{
    public class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        public decimal SubTotal { get; set; }
    }
}
