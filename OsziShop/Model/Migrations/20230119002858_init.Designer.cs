﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configurations;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(OsziDbContext))]
    [Migration("20230119002858_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("LAST_NAME");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentId")
                        .HasColumnType("INT")
                        .HasColumnName("PAYMENT_ID");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Model.Entities.AccountAddress", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("USERNAME");

                    b.Property<int>("AddressId")
                        .HasColumnType("INT")
                        .HasColumnName("ADDRESS_ID");

                    b.HasKey("Username", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("ACCOUNT_has_ADDRESS_JT");
                });

            modelBuilder.Entity("Model.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ADDRESS_ID");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("CITY");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("COUNTRY_NAME");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INT")
                        .HasColumnName("POSTAL_CODE");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("STATE");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("STREET");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("INT")
                        .HasColumnName("STREET_NUMBER");

                    b.HasKey("AddressId");

                    b.ToTable("ADDRESSES");
                });

            modelBuilder.Entity("Model.Entities.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ARTICLE_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("DESIGNATION");

                    b.Property<float>("Price")
                        .HasColumnType("FLOAT")
                        .HasColumnName("PRICE");

                    b.HasKey("ArticleId");

                    b.ToTable("ARTICLES");
                });

            modelBuilder.Entity("Model.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("INT")
                        .HasColumnName("ARTICLE_ID");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INT")
                        .HasColumnName("CATEGORY_ID");

                    b.HasKey("ArticleId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ARTICLE_has_CATEGORY_JT");
                });

            modelBuilder.Entity("Model.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("DESIGNATION");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("INT");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("CATEGORIES");
                });

            modelBuilder.Entity("Model.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ORDER_ID");

                    b.Property<int>("BillingAddress")
                        .HasColumnType("INT");

                    b.Property<int>("DeliveryAddress")
                        .HasColumnType("INT");

                    b.Property<DateTime>("OrderingTime")
                        .HasColumnType("DATETIME")
                        .HasColumnName("ORDERING_TIME");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("OrderId");

                    b.HasIndex("BillingAddress")
                        .IsUnique();

                    b.HasIndex("DeliveryAddress")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("ORDERS");
                });

            modelBuilder.Entity("Model.Entities.OrderArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("INT")
                        .HasColumnName("ARTICLE_ID");

                    b.Property<int>("OrderId")
                        .HasColumnType("INT")
                        .HasColumnName("ORDER_ID");

                    b.HasKey("ArticleId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ORDER_has_ARTICLE_JT");
                });

            modelBuilder.Entity("Model.Entities.Webshop", b =>
                {
                    b.Property<int>("WebshopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("WEBSHOP_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("NAME");

                    b.HasKey("WebshopId");

                    b.ToTable("WEBSHOPS");
                });

            modelBuilder.Entity("Model.Entities.WebshopArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("INT")
                        .HasColumnName("ARTICLE_ID");

                    b.Property<int>("WebShopId")
                        .HasColumnType("INT")
                        .HasColumnName("WEBSHOP_ID");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(5,2)")
                        .HasColumnName("PRICE");

                    b.Property<int>("Stock")
                        .HasColumnType("INT")
                        .HasColumnName("STOCK");

                    b.HasKey("ArticleId", "WebShopId");

                    b.HasIndex("WebShopId");

                    b.ToTable("WEBSHOP_has_ARTICLE_JT");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Model.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Model.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Model.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.AccountAddress", b =>
                {
                    b.HasOne("Model.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Model.Entities.ArticleCategory", b =>
                {
                    b.HasOne("Model.Entities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Model.Entities.Category", b =>
                {
                    b.HasOne("Model.Entities.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Model.Entities.Order", b =>
                {
                    b.HasOne("Model.Entities.Address", null)
                        .WithOne("OrderBilling")
                        .HasForeignKey("Model.Entities.Order", "BillingAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Address", null)
                        .WithOne("OrderDelivery")
                        .HasForeignKey("Model.Entities.Order", "DeliveryAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Account", "Account")
                        .WithOne("Order")
                        .HasForeignKey("Model.Entities.Order", "UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Model.Entities.OrderArticle", b =>
                {
                    b.HasOne("Model.Entities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Model.Entities.WebshopArticle", b =>
                {
                    b.HasOne("Model.Entities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Webshop", "Webshop")
                        .WithMany()
                        .HasForeignKey("WebShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Webshop");
                });

            modelBuilder.Entity("Model.Entities.Account", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Address", b =>
                {
                    b.Navigation("OrderBilling")
                        .IsRequired();

                    b.Navigation("OrderDelivery")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}