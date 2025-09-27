using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entitys
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required , MaxLength (50)]
        public string UserName { get; set; }
        [Required , MaxLength (100)]
        public string UserEmail { get; set; } 
        [Required , MaxLength (20)]
        public string UserPassword { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
