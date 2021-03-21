using System;
using System.Collections.Generic;
using System.Text;
using Zovi_Fashion.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Zovi_Fashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Brand>  Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductReview> ProductReviews { get; set; }

        public DbSet<Studio> Studios { get; set; }
    }
}
