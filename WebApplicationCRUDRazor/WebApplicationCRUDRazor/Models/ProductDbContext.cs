﻿using Microsoft.EntityFrameworkCore;

namespace WebApplicationCRUDRazor.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options) { 
        
        }  

    }
}
