using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
    }
}
