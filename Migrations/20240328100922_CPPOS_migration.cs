using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP_POS.Migrations
{
    /// <inheritdoc />
    public partial class CPPOS_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Contractors",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Name = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Address = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        ContractorType = table.Column<short>(type: "smallint", nullable: false),
            //        Activity = table.Column<bool>(type: "bit", nullable: true),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        DeletedBy = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        Deletedtime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Contractor", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MeasurementUnits",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        WeightType = table.Column<short>(type: "smallint", nullable: false),
            //        Name = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MeasurementUnits", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductCategories",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Name = table.Column<byte[]>(type: "varbinary(512)", maxLength: 512, nullable: false),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductCategory", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Purchases",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        PurchaseDate = table.Column<DateOnly>(type: "date", nullable: false),
            //        SupplierId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
            //        Deletedtime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Purchases", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Purchases_Contractors",
            //            column: x => x.SupplierId,
            //            principalTable: "Contractors",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sales",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        SalesDate = table.Column<DateOnly>(type: "date", nullable: false),
            //        CustomerId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        Deletedtime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sales", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sales_Contractors",
            //            column: x => x.CustomerId,
            //            principalTable: "Contractors",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Products",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Name = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        CategoryId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        UnitId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        Description = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Product_ProductCategory",
            //            column: x => x.CategoryId,
            //            principalTable: "ProductCategories",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Products_MeasurementUnits",
            //            column: x => x.UnitId,
            //            principalTable: "MeasurementUnits",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PurchaseDetails",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        PurchaseId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        ProductId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        UnitId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Rate = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        Quantity = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        Deletedtime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PurchaseDetails", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_PurchaseDetails_MeasurementUnits",
            //            column: x => x.UnitId,
            //            principalTable: "MeasurementUnits",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PurchaseDetails_Products",
            //            column: x => x.ProductId,
            //            principalTable: "Products",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PurchaseDetails_Purchases",
            //            column: x => x.PurchaseId,
            //            principalTable: "Purchases",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SaleDetails",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        SalesId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        ProductId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        UnitId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: false),
            //        Rate = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        Quantity = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        Amount = table.Column<decimal>(type: "decimal(30,10)", nullable: false),
            //        DBUserId = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        DBServertime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeletedBy = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
            //        Deletedtime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SaleDetails", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_SaleDetails_MeasurementUnits",
            //            column: x => x.UnitId,
            //            principalTable: "MeasurementUnits",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_SaleDetails_Products",
            //            column: x => x.ProductId,
            //            principalTable: "Products",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_SaleDetails_Sales",
            //            column: x => x.SalesId,
            //            principalTable: "Sales",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Products_CategoryId",
            //    table: "Products",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Products_UnitId",
            //    table: "Products",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseDetails_ProductId",
            //    table: "PurchaseDetails",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseDetails_PurchaseId",
            //    table: "PurchaseDetails",
            //    column: "PurchaseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PurchaseDetails_UnitId",
            //    table: "PurchaseDetails",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Purchases_SupplierId",
            //    table: "Purchases",
            //    column: "SupplierId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SaleDetails_ProductId",
            //    table: "SaleDetails",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SaleDetails_SalesId",
            //    table: "SaleDetails",
            //    column: "SalesId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SaleDetails_UnitId",
            //    table: "SaleDetails",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sales_CustomerId",
            //    table: "Sales",
            //    column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "Roles");

            //migrationBuilder.DropTable(
            //    name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "Users");

            //migrationBuilder.DropTable(
            //    name: "Purchases");

            //migrationBuilder.DropTable(
            //    name: "Products");

            //migrationBuilder.DropTable(
            //    name: "Sales");

            //migrationBuilder.DropTable(
            //    name: "ProductCategories");

            //migrationBuilder.DropTable(
            //    name: "MeasurementUnits");

            //migrationBuilder.DropTable(
            //    name: "Contractors");
        }
    }
}
