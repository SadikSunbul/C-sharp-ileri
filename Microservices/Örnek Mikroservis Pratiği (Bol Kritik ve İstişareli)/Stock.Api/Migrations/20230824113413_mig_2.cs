using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stock.Api.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Count", "ProductId" },
                values: new object[,]
                {
                    { new Guid("64743bae-fc71-4902-af24-500c901b1a6f"), 13, new Guid("4c6ca521-6c92-4cc7-b631-7f639675c2e6") },
                    { new Guid("833fe012-fcb7-4e9e-a9ba-1c52655fde7d"), 5, new Guid("2a6251af-63b6-49d3-b2a4-e078f5299a77") },
                    { new Guid("9df1ff08-1f24-44d5-a45f-bfb7578f004d"), 77, new Guid("74356621-9660-4cf9-9eba-c90e19448ef5") },
                    { new Guid("c05e5da8-0bbc-427d-8ee7-31a99fdfb9fa"), 123, new Guid("71d41dd6-4b2d-4d7f-be75-9609cb31b5dd") },
                    { new Guid("e4393158-0595-47a9-b36f-36b9b7b9fe96"), 200, new Guid("6f3d5a32-b5b2-4eff-a3a7-a69ca46f9691") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("64743bae-fc71-4902-af24-500c901b1a6f"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("833fe012-fcb7-4e9e-a9ba-1c52655fde7d"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("9df1ff08-1f24-44d5-a45f-bfb7578f004d"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("c05e5da8-0bbc-427d-8ee7-31a99fdfb9fa"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("e4393158-0595-47a9-b36f-36b9b7b9fe96"));
        }
    }
}
