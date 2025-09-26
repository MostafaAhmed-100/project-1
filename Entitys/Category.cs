﻿
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; }

        [Required, MaxLength(1000)]
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}