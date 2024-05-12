using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP_POS.Migrations
{
    /// <inheritdoc />
    public partial class CPPOS_migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Product_ProductCategory",
            //    table: "Products");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_MeasurementUnits",
            //    table: "Products");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_MeasurementUnits",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_Products",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_Purchases",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Purchases_Contractors",
            //    table: "Purchases");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_MeasurementUnits",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_Products",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_Sales",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Sales_Contractors",
            //    table: "Sales");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Product",
            //    table: "Products");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ProductCategory",
            //    table: "ProductCategories");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Contractor",
            //    table: "Contractors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "Sales",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "Sales",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "SaleDetails",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "SaleDetails",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "Purchases",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "Purchases",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "PurchaseDetails",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "PurchaseDetails",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "Products",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "Products",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "ProductCategories",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "ProductCategories",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "MeasurementUnits",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "MeasurementUnits",
            //    newName: "Dbservertime");

            //migrationBuilder.RenameColumn(
            //    name: "DBUserId",
            //    table: "Contractors",
            //    newName: "DbuserId");

            //migrationBuilder.RenameColumn(
            //    name: "DBServertime",
            //    table: "Contractors",
            //    newName: "Dbservertime");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Sales",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Sales",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "Sales",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "Sales",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "CustomerId",
            //    table: "Sales",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Sales",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "SaleDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "SalesId",
            //    table: "SaleDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Rate",
            //    table: "SaleDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Quantity",
            //    table: "SaleDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "SaleDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "SaleDetails",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "SaleDetails",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "SaleDetails",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "SaleDetails",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Amount",
            //    table: "SaleDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "SaleDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "SupplierId",
            //    table: "Purchases",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "Purchases",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Purchases",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Purchases",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(12)",
            //    oldUnicode: false,
            //    oldMaxLength: 12,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "Purchases",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "Purchases",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Purchases",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Rate",
            //    table: "PurchaseDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Quantity",
            //    table: "PurchaseDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PurchaseId",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "PurchaseDetails",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "PurchaseDetails",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Amount",
            //    table: "PurchaseDetails",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(30,10)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "PurchaseDetails",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "Products",
            //    type: "nvarchar(450)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "Products",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "Products",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "Products",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "Products",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "CategoryId",
            //    table: "Products",
            //    type: "nvarchar(450)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Products",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "Name",
            //    table: "ProductCategories",
            //    type: "varbinary(max)",
            //    nullable: false,
            //    oldClrType: typeof(byte[]),
            //    oldType: "varbinary(512)",
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "ProductCategories",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "ProductCategories",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "ProductCategories",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "MeasurementUnits",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "MeasurementUnits",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "MeasurementUnits",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "MeasurementUnits",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "Contractors",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Mobile",
            //    table: "Contractors",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(50)",
            //    oldUnicode: false,
            //    oldMaxLength: 50);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Contractors",
            //    type: "datetime2",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Contractors",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DbuserId",
            //    table: "Contractors",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Dbservertime",
            //    table: "Contractors",
            //    type: "datetime2",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Address",
            //    table: "Contractors",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Contractors",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(512)",
            //    oldUnicode: false,
            //    oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetRoles",
            //    type: "nvarchar(256)",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Products",
            //    table: "Products",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ProductCategories",
            //    table: "ProductCategories",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Contractors",
            //    table: "Contractors",
            //    column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Products_MeasurementUnits_UnitId",
            //    table: "Products",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Products_ProductCategories_CategoryId",
            //    table: "Products",
            //    column: "CategoryId",
            //    principalTable: "ProductCategories",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_MeasurementUnits_UnitId",
            //    table: "PurchaseDetails",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_Products_ProductId",
            //    table: "PurchaseDetails",
            //    column: "ProductId",
            //    principalTable: "Products",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_Purchases_PurchaseId",
            //    table: "PurchaseDetails",
            //    column: "PurchaseId",
            //    principalTable: "Purchases",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Purchases_Contractors_SupplierId",
            //    table: "Purchases",
            //    column: "SupplierId",
            //    principalTable: "Contractors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_MeasurementUnits_UnitId",
            //    table: "SaleDetails",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_Products_ProductId",
            //    table: "SaleDetails",
            //    column: "ProductId",
            //    principalTable: "Products",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_Sales_SalesId",
            //    table: "SaleDetails",
            //    column: "SalesId",
            //    principalTable: "Sales",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Sales_Contractors_CustomerId",
            //    table: "Sales",
            //    column: "CustomerId",
            //    principalTable: "Contractors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_MeasurementUnits_UnitId",
            //    table: "Products");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_ProductCategories_CategoryId",
            //    table: "Products");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_MeasurementUnits_UnitId",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_Products_ProductId",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PurchaseDetails_Purchases_PurchaseId",
            //    table: "PurchaseDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Purchases_Contractors_SupplierId",
            //    table: "Purchases");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_MeasurementUnits_UnitId",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_Products_ProductId",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_SaleDetails_Sales_SalesId",
            //    table: "SaleDetails");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Sales_Contractors_CustomerId",
            //    table: "Sales");

            //migrationBuilder.DropTable(
            //    name: "AspNetRoleClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserLogins");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserRoles");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserTokens");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Products",
            //    table: "Products");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ProductCategories",
            //    table: "ProductCategories");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Contractors",
            //    table: "Contractors");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUsers",
            //    table: "AspNetUsers");

            //migrationBuilder.DropIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers");

            //migrationBuilder.DropIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetRoles",
            //    table: "AspNetRoles");

            //migrationBuilder.DropIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles");

            //migrationBuilder.DropColumn(
            //    name: "Discriminator",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "Name",
            //    table: "AspNetUsers");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUsers",
            //    newName: "Users");

            //migrationBuilder.RenameTable(
            //    name: "AspNetRoles",
            //    newName: "Roles");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "Sales",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "Sales",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "SaleDetails",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "SaleDetails",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "Purchases",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "Purchases",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "PurchaseDetails",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "PurchaseDetails",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "Products",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "Products",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "ProductCategories",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "ProductCategories",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "MeasurementUnits",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "MeasurementUnits",
            //    newName: "DBServertime");

            //migrationBuilder.RenameColumn(
            //    name: "DbuserId",
            //    table: "Contractors",
            //    newName: "DBUserId");

            //migrationBuilder.RenameColumn(
            //    name: "Dbservertime",
            //    table: "Contractors",
            //    newName: "DBServertime");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Sales",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Sales",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "Sales",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "Sales",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "CustomerId",
            //    table: "Sales",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Sales",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "SalesId",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Rate",
            //    table: "SaleDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Quantity",
            //    table: "SaleDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "SaleDetails",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "SaleDetails",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Amount",
            //    table: "SaleDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "SaleDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "SupplierId",
            //    table: "Purchases",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "Purchases",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Purchases",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Purchases",
            //    type: "varchar(12)",
            //    unicode: false,
            //    maxLength: 12,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "Purchases",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "Purchases",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Purchases",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Rate",
            //    table: "PurchaseDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Quantity",
            //    table: "PurchaseDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PurchaseId",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "PurchaseDetails",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "PurchaseDetails",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Amount",
            //    table: "PurchaseDetails",
            //    type: "decimal(30,10)",
            //    nullable: false,
            //    oldClrType: typeof(decimal),
            //    oldType: "decimal(18,2)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "PurchaseDetails",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UnitId",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "Products",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "CategoryId",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Products",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "Name",
            //    table: "ProductCategories",
            //    type: "varbinary(512)",
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(byte[]),
            //    oldType: "varbinary(max)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "ProductCategories",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "ProductCategories",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "ProductCategories",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "MeasurementUnits",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "MeasurementUnits",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "MeasurementUnits",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "MeasurementUnits",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "Contractors",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Mobile",
            //    table: "Contractors",
            //    type: "varchar(50)",
            //    unicode: false,
            //    maxLength: 50,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "Deletedtime",
            //    table: "Contractors",
            //    type: "datetime",
            //    nullable: true,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DeletedBy",
            //    table: "Contractors",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "DBUserId",
            //    table: "Contractors",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DBServertime",
            //    table: "Contractors",
            //    type: "datetime",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Address",
            //    table: "Contractors",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Contractors",
            //    type: "varchar(512)",
            //    unicode: false,
            //    maxLength: 512,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Product",
            //    table: "Products",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ProductCategory",
            //    table: "ProductCategories",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Contractor",
            //    table: "Contractors",
            //    column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Product_ProductCategory",
            //    table: "Products",
            //    column: "CategoryId",
            //    principalTable: "ProductCategories",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Products_MeasurementUnits",
            //    table: "Products",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_MeasurementUnits",
            //    table: "PurchaseDetails",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_Products",
            //    table: "PurchaseDetails",
            //    column: "ProductId",
            //    principalTable: "Products",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PurchaseDetails_Purchases",
            //    table: "PurchaseDetails",
            //    column: "PurchaseId",
            //    principalTable: "Purchases",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Purchases_Contractors",
            //    table: "Purchases",
            //    column: "SupplierId",
            //    principalTable: "Contractors",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_MeasurementUnits",
            //    table: "SaleDetails",
            //    column: "UnitId",
            //    principalTable: "MeasurementUnits",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_Products",
            //    table: "SaleDetails",
            //    column: "ProductId",
            //    principalTable: "Products",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SaleDetails_Sales",
            //    table: "SaleDetails",
            //    column: "SalesId",
            //    principalTable: "Sales",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Sales_Contractors",
            //    table: "Sales",
            //    column: "CustomerId",
            //    principalTable: "Contractors",
            //    principalColumn: "Id");
        }
    }
}
