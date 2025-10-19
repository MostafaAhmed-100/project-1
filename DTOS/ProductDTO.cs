using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class ProductDTO{

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public IFormFile? ImageFile { get; set; }

    }
}
