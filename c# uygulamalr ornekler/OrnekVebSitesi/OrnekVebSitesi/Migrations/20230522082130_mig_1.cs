using Microsoft.EntityFrameworkCore.Migrations;

namespace OrnekVebSitesi.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsimSoyiism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.Id);
                    table.CheckConstraint("CHK_Email", "Email LIKE '%_@__%.__%'");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_Email",
                table: "Kullanıcılar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_Email_Şifre",
                table: "Kullanıcılar",
                columns: new[] { "Email", "Şifre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanıcılar");
        }
    }
}
