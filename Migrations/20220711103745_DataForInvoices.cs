using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMovies.Migrations
{
    public partial class DataForInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: false),
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetail", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "CreationDate", "InvoiceNumber" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "InvoiceDetail",
                columns: new[] { "Id", "InvoiceId", "Price", "Product", "Quantity", "Total" },
                values: new object[,]
                {
                    { 3, 2, 350.99m, null, 0, 0m },
                    { 4, 2, 10m, null, 0, 0m },
                    { 5, 2, 45.50m, null, 0, 0m },
                    { 6, 3, 17.99m, null, 0, 0m },
                    { 7, 3, 14m, null, 0, 0m },
                    { 8, 3, 45m, null, 0, 0m },
                    { 9, 3, 100m, null, 0, 0m },
                    { 10, 4, 371m, null, 0, 0m },
                    { 11, 4, 114.99m, null, 0, 0m },
                    { 12, 4, 425m, null, 0, 0m },
                    { 13, 4, 1000m, null, 0, 0m },
                    { 14, 4, 5m, null, 0, 0m },
                    { 15, 4, 2.99m, null, 0, 0m },
                    { 16, 5, 50m, null, 0, 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceDetail");
        }
    }
}
