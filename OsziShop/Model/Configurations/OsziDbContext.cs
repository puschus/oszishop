using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Model.Entities;

namespace Model.Configurations;

public class OsziDbContext : IdentityDbContext<Account>
{
    //DB Sets
    public DbSet<Address> Addresses { get; set; }
    public DbSet<AccountAddress> AccountAddresses { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<ArticleCategory> ArticleCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderArticle> OrderArticles { get; set; }
    public DbSet<Webshop> WebShops { get; set; }
    public DbSet<WebshopArticle> WebShopArticles { get; set; }

    public OsziDbContext(DbContextOptions<OsziDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Webshop>();

        modelBuilder.Entity<WebshopArticle>()
            .HasKey(k => new
            {
                k.ArticleId,
                k.WebShopId
            });

        modelBuilder.Entity<AccountAddress>()
            .HasKey(k => new
            {
                k.Username,
                k.AddressId
            });

        modelBuilder.Entity<ArticleCategory>()
            .HasKey(k => new
            {
                k.ArticleId,
                k.CategoryId
            });

        modelBuilder.Entity<OrderArticle>()
            .HasKey(k => new
            {
                k.ArticleId,
                k.OrderId
            });
        
        modelBuilder.Entity<WebshopArticle>()
            .HasOne(m => m.Webshop)
            .WithMany()
            .HasForeignKey(k => k.WebShopId);
        
        modelBuilder.Entity<WebshopArticle>()
            .HasOne(m => m.Article)
            .WithMany()
            .HasForeignKey(k => k.ArticleId);

        modelBuilder.Entity<ArticleCategory>()
            .HasOne(a => a.Article)
            .WithMany()
            .HasForeignKey(a => a.ArticleId);

        modelBuilder.Entity<ArticleCategory>()
            .HasOne(c => c.Category)
            .WithMany()
            .HasForeignKey(c => c.CategoryId);

        modelBuilder.Entity<OrderArticle>()
            .HasOne(o => o.Order)
            .WithMany()
            .HasForeignKey(o => o.OrderId);

        modelBuilder.Entity<OrderArticle>()
            .HasOne(a => a.Article)
            .WithMany()
            .HasForeignKey(a => a.ArticleId);

        modelBuilder.Entity<Category>()
            .HasOne(c => c.ParentCategory)
            .WithMany()
            .HasForeignKey(c => c.ParentCategoryId);

        modelBuilder.Entity<Address>()
            .Property(a => a.Country)
            .HasConversion<string>();

        modelBuilder.Entity<Address>()
            .HasOne(a => a.OrderBilling)
            .WithOne()
            .HasForeignKey<Order>(o => o.BillingAddress);

        modelBuilder.Entity<Address>()
            .HasOne(a => a.OrderDelivery)
            .WithOne()
            .HasForeignKey<Order>(o => o.DeliveryAddress);

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Order)
            .WithOne(o => o.Account)
            .HasForeignKey<Order>(o => o.UserName);

        modelBuilder.Entity<AccountAddress>()
            .HasOne(aa => aa.Address)
            .WithMany()
            .HasForeignKey(aa => aa.AddressId);

        modelBuilder.Entity<AccountAddress>()
            .HasOne(aa => aa.Account)
            .WithMany()
            .HasForeignKey(aa => aa.Username);
    }
}