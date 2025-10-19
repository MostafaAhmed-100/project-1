using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class OrderDTO
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
    }
}
