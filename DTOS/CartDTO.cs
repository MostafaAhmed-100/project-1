using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class CartDTO
    {
        public decimal Size { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
 
    }
}
