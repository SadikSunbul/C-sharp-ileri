using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketCustomer_Basket_BasketsId",
                table: "BasketCustomer");

            migrationBuilder.DropTable(
                name: "BasketFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "Baskets");

            migrationBuilder.AddColumn<Guid>(
                name: "BasketId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_BasketId",
                table: "Foods",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCustomer_Baskets_BasketsId",
                table: "BasketCustomer",
                column: "BasketsId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Baskets_BasketId",
                table: "Foods",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketCustomer_Baskets_BasketsId",
                table: "BasketCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Baskets_BasketId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_BasketId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Foods");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Basket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "Id");

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
                        name: "FK_BasketFood_Basket_BasketsId",
                        column: x => x.BasketsId,
                        principalTable: "Basket",
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

            migrationBuilder.AddForeignKey(
                name: "FK_BasketCustomer_Basket_BasketsId",
                table: "BasketCustomer",
                column: "BasketsId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
