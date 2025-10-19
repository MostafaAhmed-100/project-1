using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class Address
    {
        public int UserId { get; set; }
        public string City { get; set; }

        public string HomeAddress { get; set; }

        public string State { get; set; }

        public string Zip_Code { get; set; }
    }
}
