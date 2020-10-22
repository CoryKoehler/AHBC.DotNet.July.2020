using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using October21stEFCoreCodeFirst.DataLayer.Models;
using System;

namespace October21stEFCoreCodeFirst.DataLayer.Context
{
    public class BookStoreContext : DbContext
        {
            public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

            public DbSet<Inventory> StoreInventory { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Publisher> Publishers { get; set; }
            public DbSet<Book> Books { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderedItem> OrderedItems { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Inventory>(i =>
                {
                    i.HasKey(k => k.Id);
                    i.HasOne<Book>().WithMany().HasForeignKey(k => k.BookId);
                });

                modelBuilder.Entity<Author>(a =>
                {
                    a.HasKey(k => k.Id);
                });

                modelBuilder.Entity<Publisher>(p =>
                {
                    p.HasKey(k => k.Id);
                });

                modelBuilder.Entity<Book>(b =>
                {
                    b.HasKey(k => k.Id);
                    b.HasOne(a => a.Author).WithMany(a => a.Books).HasForeignKey(k => k.AuthorId);
                    b.HasOne(p => p.Publisher).WithMany(p => p.Books).HasForeignKey(k => k.PublisherId);
                });

                modelBuilder.Entity<Customer>(c =>
                {
                    c.HasKey(k => k.Id);
                });


                modelBuilder.Entity<Order>(o =>
                {
                    o.HasKey(k => k.Id);
                    o.HasOne(_ => _.Customer).WithMany(_ => _.Orders).HasForeignKey(k => k.CustomerId);
                });

                modelBuilder.Entity<OrderedItem>(oi =>
                {
                    oi.HasKey(k => new { k.OrderId, k.BookId });
                    oi.HasOne(_ => _.Order).WithMany(_ => _.OrderedItems).HasForeignKey(o => o.OrderId);
                    oi.HasOne(_ => _.Book).WithMany(_ => _.OrderedItems).HasForeignKey(b => b.BookId);
                });

                base.OnModelCreating(modelBuilder);
            }
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookStoreContext>
        {
            public BookStoreContext CreateDbContext(string[] args)
            {
                var connectionString = Environment.GetEnvironmentVariable("BookStoreConnectionString");

                var builder = new DbContextOptionsBuilder<BookStoreContext>();

                if (connectionString != null)
                {
                    builder.UseSqlServer(connectionString);
                }
                else
                {
                    builder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BookStore;Trusted_Connection=true;MultipleActiveResultSets=true");
                }

                return new BookStoreContext(builder.Options);
            }
        }
    }

