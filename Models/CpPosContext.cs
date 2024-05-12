using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CP_POS.Models;

public partial class CpPosContext :  IdentityDbContext
{
    public CpPosContext()
    {
    }

    public CpPosContext(DbContextOptions<CpPosContext> options)
        : base(options)
    {
    }


    public  DbSet<ApplicationUser> ApplicationUser { get; set; }
    public virtual DbSet<Contractor> Contractors { get; set; }

    public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

    public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

    public virtual DbSet<SaleInvoice> SaleInvoices { get; set; }

    public virtual DbSet<SaleInvoiceDetail> SaleInvoiceDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6T02H53; Database=CP_POS; user Id=sa;Password=12774;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{




    ////modelBuilder.Entity<Contractor>(entity =>
    ////    {
    ////        entity.HasKey(e => e.Id).HasName("PK_Contractor");

    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Address)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.DeletedBy)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Deletedtime).HasColumnType("datetime");
    ////        entity.Property(e => e.Mobile)
    ////            .HasMaxLength(50)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Name)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////    });

    ////    modelBuilder.Entity<MeasurementUnit>(entity =>
    ////    {
    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.Name)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////    });

    ////    modelBuilder.Entity<Product>(entity =>
    ////    {
    ////        entity.HasKey(e => e.Id).HasName("PK_Product");

    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.CategoryId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.Description)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Name)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.UnitId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);

    ////        entity.HasOne(d => d.Category).WithMany(p => p.Products)
    ////            .HasForeignKey(d => d.CategoryId)
    ////            .HasConstraintName("FK_Product_ProductCategory");

    ////        entity.HasOne(d => d.Unit).WithMany(p => p.Products)
    ////            .HasForeignKey(d => d.UnitId)
    ////            .HasConstraintName("FK_Products_MeasurementUnits");
    ////    });

    ////    modelBuilder.Entity<ProductCategory>(entity =>
    ////    {
    ////        entity.HasKey(e => e.Id).HasName("PK_ProductCategory");

    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.Name).HasMaxLength(512);
    ////    });

    ////    modelBuilder.Entity<Purchase>(entity =>
    ////    {
    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.DeletedBy)
    ////            .HasMaxLength(12)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Deletedtime).HasColumnType("datetime");
    ////        entity.Property(e => e.Description)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.SupplierId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);

    ////        entity.HasOne(d => d.Supplier).WithMany(p => p.Purchases)
    ////            .HasForeignKey(d => d.SupplierId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_Purchases_Contractors");
    ////    });

    ////    modelBuilder.Entity<PurchaseDetail>(entity =>
    ////    {
    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Amount).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.DeletedBy)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Deletedtime).HasColumnType("datetime");
    ////        entity.Property(e => e.ProductId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.PurchaseId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Quantity).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.Rate).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.UnitId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);

    ////        entity.HasOne(d => d.Product).WithMany(p => p.PurchaseDetails)
    ////            .HasForeignKey(d => d.ProductId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_PurchaseDetails_Products");

    ////        entity.HasOne(d => d.Purchase).WithMany(p => p.PurchaseDetails)
    ////            .HasForeignKey(d => d.PurchaseId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_PurchaseDetails_Purchases");

    ////        entity.HasOne(d => d.Unit).WithMany(p => p.PurchaseDetails)
    ////            .HasForeignKey(d => d.UnitId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_PurchaseDetails_MeasurementUnits");
    ////    });

    ////    modelBuilder.Entity<Sale>(entity =>
    ////    {
    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.CustomerId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.DeletedBy)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Deletedtime).HasColumnType("datetime");

    ////        entity.HasOne(d => d.Customer).WithMany(p => p.Sales)
    ////            .HasForeignKey(d => d.CustomerId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_Sales_Contractors");
    ////    });

    ////    modelBuilder.Entity<SaleDetail>(entity =>
    ////    {
    ////        entity.Property(e => e.Id)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Amount).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.Dbservertime)
    ////            .HasColumnType("datetime")
    ////            .HasColumnName("DBServertime");
    ////        entity.Property(e => e.DbuserId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false)
    ////            .HasColumnName("DBUserId");
    ////        entity.Property(e => e.DeletedBy)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Deletedtime).HasColumnType("datetime");
    ////        entity.Property(e => e.ProductId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.Quantity).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.Rate).HasColumnType("decimal(30, 10)");
    ////        entity.Property(e => e.SalesId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);
    ////        entity.Property(e => e.UnitId)
    ////            .HasMaxLength(512)
    ////            .IsUnicode(false);

    ////        entity.HasOne(d => d.Product).WithMany(p => p.SaleDetails)
    ////            .HasForeignKey(d => d.ProductId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_SaleDetails_Products");

    ////        entity.HasOne(d => d.Sales).WithMany(p => p.SaleDetails)
    ////            .HasForeignKey(d => d.SalesId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_SaleDetails_Sales");

    ////        entity.HasOne(d => d.Unit).WithMany(p => p.SaleDetails)
    ////            .HasForeignKey(d => d.UnitId)
    ////            .OnDelete(DeleteBehavior.ClientSetNull)
    ////            .HasConstraintName("FK_SaleDetails_MeasurementUnits");
    ////    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
