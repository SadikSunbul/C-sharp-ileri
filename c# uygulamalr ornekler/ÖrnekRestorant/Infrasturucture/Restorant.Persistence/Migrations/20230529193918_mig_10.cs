using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustoemrId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Masano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KartNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonKullanımTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cvv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustoemrId",
                        column: x => x.CustoemrId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustoemrId",
                table: "Payments",
                column: "CustoemrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
