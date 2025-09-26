﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOS
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get;  set; }
    }
}
