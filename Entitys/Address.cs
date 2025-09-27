using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entitys
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string HomeAddress { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip_Code { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

   


    }
}
