using System;
using System.Collections.Generic;
using DemoExamShoeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoExamShoeShop.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("Category", tb => tb.HasComment("Категория обуви"));

            entity.Property(e => e.CategoryId).HasComment("Уникальный идентификтор");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasComment("Название категории");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasName("PRIMARY");

            entity.ToTable("Manufacturer", tb => tb.HasComment("Производитель"));

            entity.Property(e => e.ManufacturerId).HasComment("Уникальный идентификатор");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasComment("Страна");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasComment("Название");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("Product", tb => tb.HasComment("Каталог товаров"));

            entity.HasIndex(e => e.CategoryId, "fk_Product_Category1_idx");

            entity.HasIndex(e => e.ManufacturerId, "fk_Product_Manufacturer1_idx");

            entity.HasIndex(e => e.SupplierId, "fk_Product_Supplier1_idx");

            entity.Property(e => e.ProductId).HasComment("Уникальный идентификатор");
            entity.Property(e => e.CategoryId).HasComment("Ссылка на категорию товара");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasComment("Описание");
            entity.Property(e => e.Discount)
                .HasPrecision(10)
                .HasComment("Скидка");
            entity.Property(e => e.ManufacturerId).HasComment("Ссылка на производителя");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasComment("Название");
            entity.Property(e => e.PhotoPath)
                .HasMaxLength(255)
                .HasComment("Ссылка на картинку товара");
            entity.Property(e => e.Price)
                .HasPrecision(10)
                .HasComment("Цена");
            entity.Property(e => e.Stock).HasComment("Остаток");
            entity.Property(e => e.SupplierId).HasComment("Ссылка на поставщика");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Product_Category1");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Product_Manufacturer1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Product_Supplier1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("Role", tb => tb.HasComment("Таблица с ролями пользователя"));

            entity.Property(e => e.RoleId).HasComment("Уникальный идентификатор");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasComment("Название роли");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.ToTable("Supplier", tb => tb.HasComment("Поставщик"));

            entity.Property(e => e.SupplierId).HasComment("Уникальный идентификатор");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasComment("Почта");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasComment("Номер телефона");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("User", tb => tb.HasComment("Таблица с информацией о пользователе"));

            entity.HasIndex(e => e.RoleId, "fk_User_Role_idx");

            entity.Property(e => e.UserId).HasComment("Уникальный идентификатор");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasComment("Имя пользователя");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasComment("Пароль");
            entity.Property(e => e.RoleId).HasComment("Ссылка на роль");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
