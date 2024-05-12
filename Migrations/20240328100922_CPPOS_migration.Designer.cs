﻿// <auto-generated />
using System;
using CP_POS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CP_POS.Migrations
{
    [DbContext(typeof(CpPosContext))]
    [Migration("20240328100922_CPPOS_migration")]
    partial class CPPOS_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CP_POS.Models.Contractor", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<bool?>("Activity")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<short>("ContractorType")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Deletedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id")
                        .HasName("PK_Contractor");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("CP_POS.Models.MeasurementUnit", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<short>("WeightType")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnits");
                });

            modelBuilder.Entity("CP_POS.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Name")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("UnitId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id")
                        .HasName("PK_Product");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CP_POS.Models.ProductCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<byte[]>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varbinary(512)");

                    b.HasKey("Id")
                        .HasName("PK_ProductCategory");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CP_POS.Models.Purchase", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<DateTime?>("Deletedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateOnly>("PurchaseDate")
                        .HasColumnType("date");

                    b.Property<string>("SupplierId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("CP_POS.Models.PurchaseDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Deletedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("PurchaseId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<string>("UnitId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("UnitId");

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("CP_POS.Models.Sale", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Deletedtime")
                        .HasColumnType("datetime");

                    b.Property<DateOnly>("SalesDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CP_POS.Models.SaleDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<DateTime?>("Dbservertime")
                        .HasColumnType("datetime")
                        .HasColumnName("DBServertime");

                    b.Property<string>("DbuserId")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("DBUserId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Deletedtime")
                        .HasColumnType("datetime");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(30, 10)");

                    b.Property<string>("SalesId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("UnitId")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesId");

                    b.HasIndex("UnitId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CP_POS.Models.Product", b =>
                {
                    b.HasOne("CP_POS.Models.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_ProductCategory");

                    b.HasOne("CP_POS.Models.MeasurementUnit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .HasConstraintName("FK_Products_MeasurementUnits");

                    b.Navigation("Category");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("CP_POS.Models.Purchase", b =>
                {
                    b.HasOne("CP_POS.Models.Contractor", "Supplier")
                        .WithMany("Purchases")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchases_Contractors");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("CP_POS.Models.PurchaseDetail", b =>
                {
                    b.HasOne("CP_POS.Models.Product", "Product")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Products");

                    b.HasOne("CP_POS.Models.Purchase", "Purchase")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Purchases");

                    b.HasOne("CP_POS.Models.MeasurementUnit", "Unit")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("UnitId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_MeasurementUnits");

                    b.Navigation("Product");

                    b.Navigation("Purchase");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("CP_POS.Models.Sale", b =>
                {
                    b.HasOne("CP_POS.Models.Contractor", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Sales_Contractors");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CP_POS.Models.SaleDetail", b =>
                {
                    b.HasOne("CP_POS.Models.Product", "Product")
                        .WithMany("SaleDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_SaleDetails_Products");

                    b.HasOne("CP_POS.Models.Sale", "Sales")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SalesId")
                        .IsRequired()
                        .HasConstraintName("FK_SaleDetails_Sales");

                    b.HasOne("CP_POS.Models.MeasurementUnit", "Unit")
                        .WithMany("SaleDetails")
                        .HasForeignKey("UnitId")
                        .IsRequired()
                        .HasConstraintName("FK_SaleDetails_MeasurementUnits");

                    b.Navigation("Product");

                    b.Navigation("Sales");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("CP_POS.Models.Contractor", b =>
                {
                    b.Navigation("Purchases");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("CP_POS.Models.MeasurementUnit", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("PurchaseDetails");

                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("CP_POS.Models.Product", b =>
                {
                    b.Navigation("PurchaseDetails");

                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("CP_POS.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CP_POS.Models.Purchase", b =>
                {
                    b.Navigation("PurchaseDetails");
                });

            modelBuilder.Entity("CP_POS.Models.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
