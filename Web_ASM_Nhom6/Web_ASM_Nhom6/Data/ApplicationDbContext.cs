
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web_ASM_Nhom6.Models;

namespace Web_ASM_Nhom6.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Định nghĩa các DbSet cho từng thực thể (entity) trong ứng dụng
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Vouter> Vouters { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Rating> Ratings { get; set; }

        // Phương thức OnModelCreating để cấu hình mô hình và mối quan hệ giữa các thực thể
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa kiểu dữ liệu và chi tiết cho các thuộc tính decimal
            modelBuilder.Entity<Vouter>().Property(a => a.Discount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>().Property(c => c.TotalAmount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderItem>().Property(d => d.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(f => f.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<User>().HasKey(a => a.UserId);
            modelBuilder.Entity<Restaurant>().HasKey(b => b.RestaurantId);
            modelBuilder.Entity<Menu>().HasKey(c => c.MenuId);
            modelBuilder.Entity<Order>().HasKey(d => d.OrderId);
            modelBuilder.Entity<OrderItem>().HasKey(e => e.OrderItemId);
            modelBuilder.Entity<Review>().HasKey(f => f.ReviewId);
            modelBuilder.Entity<Vouter>().HasKey(h => h.VouterId);
            modelBuilder.Entity<Category>().HasKey(k => k.CategoryId);
            modelBuilder.Entity<Product>().HasKey(l => l.ProductId);


            modelBuilder.Entity<Restaurant>()
                .HasOne(a => a.Category)
                .WithMany(a => a.Restaurants)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Menu>()
                .HasOne(b => b.Restaurant)
                .WithMany(b => b.Menus)
                .HasForeignKey(b => b.RestaurantId);

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Menu)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.MenuId);

            modelBuilder.Entity<Vouter>()
                .HasOne(d => d.Product)
                .WithMany(d => d.Vouters)
                .HasForeignKey(d => d.ProductId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.Product)
                .WithMany(e => e.OrderItems)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.Order)
                .WithMany(e => e.OrderItems)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne(f => f.User)
                .WithMany(f => f.Orders)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<Review>()
                .HasOne(g => g.Product)
                .WithMany(g => g.Reviews)
                .HasForeignKey(g => g.ProductId);

            modelBuilder.Entity<Review>()
                .HasOne(g => g.User)
                .WithMany(g => g.Reviews)
                .HasForeignKey(g => g.UserId);

        }
    }
}
