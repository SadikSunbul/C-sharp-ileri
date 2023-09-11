using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LikeId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LikeId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_LikeId",
                table: "Foods",
                column: "LikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LikeId",
                table: "Customers",
                column: "LikeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Likes_LikeId",
                table: "Customers",
                column: "LikeId",
                principalTable: "Likes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Likes_LikeId",
                table: "Foods",
                column: "LikeId",
                principalTable: "Likes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Likes_LikeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Likes_LikeId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Foods_LikeId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Customers_LikeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LikeId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "LikeId",
                table: "Customers");
        }
    }
}
