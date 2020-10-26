using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using October22ndEFCoreCodeFirst.DataLayer.Models;

namespace October21stEFCoreCodeFirst.DataLayer.Context
{
    public class ProductContext : DbContext
        {
            public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Prodcuts { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>(i =>
                {
                    i.HasKey(k => k.ID);
                    i.HasData(
                        new Product { ID = 1, Name = "Basketball", Category = "Sports"},
                        new Product { ID = 2, Name = "Baseball Bat", Category = "Sports" });
                });

                base.OnModelCreating(modelBuilder);
            }
        }
    }

