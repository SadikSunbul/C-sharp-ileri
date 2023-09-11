using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Likes_LikeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Likes_LikeId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "BasketCustomer");

            migrationBuilder.DropTable(
                name: "BasketFood");

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

            migrationBuilder.DropColumn(
                name: "Adet",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Totalfiyat",
                table: "Baskets");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FoodId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FoodId",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CustomerId",
                table: "Likes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_FoodId",
                table: "Likes",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CustomerId",
                table: "Baskets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_FoodId",
                table: "Baskets",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Customers_CustomerId",
                table: "Baskets",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Foods_FoodId",
                table: "Baskets",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Customers_CustomerId",
                table: "Likes",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Foods_FoodId",
                table: "Likes",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Customers_CustomerId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Foods_FoodId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Customers_CustomerId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Foods_FoodId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_CustomerId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_FoodId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_CustomerId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_FoodId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Baskets");

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

            migrationBuilder.AddColumn<int>(
                name: "Adet",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Totalfiyat",
                table: "Baskets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "BasketCustomer",
                columns: table => new
                {
                    BasketsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketCustomer", x => new { x.BasketsId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_BasketCustomer_Baskets_BasketsId",
                        column: x => x.BasketsId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketCustomer_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Foods_LikeId",
                table: "Foods",
                column: "LikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LikeId",
                table: "Customers",
                column: "LikeId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketCustomer_CustomersId",
                table: "BasketCustomer",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketFood_FoodsId",
                table: "BasketFood",
                column: "FoodsId");

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
    }
}
