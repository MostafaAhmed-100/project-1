
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Entities
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [Required]
        public decimal Size { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int OrderId { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}