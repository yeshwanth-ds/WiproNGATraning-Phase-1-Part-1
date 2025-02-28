﻿using System.ComponentModel.DataAnnotations;

namespace WebApplicationCRUDRazor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
    }
}
