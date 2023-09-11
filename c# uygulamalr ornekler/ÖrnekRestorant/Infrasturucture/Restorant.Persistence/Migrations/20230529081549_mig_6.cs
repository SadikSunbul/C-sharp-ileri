using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Baskets_BasketId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_BasketId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "BasketFood",
                columns: table => new
                {
                    BasketsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketFood", x => new { x.BasketsId, x.FoodsId });
                    table.ForeignKey(
                        name: "FK_BasketFood_Baskets_BasketsId",
                        column: x => x.BasketsId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketFood_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketFood_FoodsId",
                table: "BasketFood",
                column: "FoodsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketFood");

            migrationBuilder.AddColumn<Guid>(
                name: "BasketId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Foods_BasketId",
                table: "Foods",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Baskets_BasketId",
                table: "Foods",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
