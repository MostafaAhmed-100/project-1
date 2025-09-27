using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
    }
}
