using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class UserDTO
    {
        public int AddressId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
