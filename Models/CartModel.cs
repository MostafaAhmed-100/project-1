using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public decimal Size { get; set; }

        public int Quantity { get; set; }

        public int OrderId { get; set; }
    }
}
