using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GirişSimilasyonu.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "EC_Sequence_calısan",
                startValue: 100L);

            migrationBuilder.CreateSequence(
                name: "EC_Sequence_kullanıcı",
                startValue: 1000L);

            migrationBuilder.CreateSequence(
                name: "KişiSequence");

            migrationBuilder.CreateTable(
                name: "Çalışanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KişiSequence]"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ÇalışanKonumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ÇalışanNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR EC_Sequence_calısan")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Çalışanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kişiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KişiSequence]"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kişiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NormalKullanıcılars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KişiSequence]"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullanıcıNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR EC_Sequence_kullanıcı")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormalKullanıcılars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NormalKullanıcılars",
                columns: new[] { "Id", "Email", "KullanıcıNo", "Soyisim", "İsim", "Şifre" },
                values: new object[,]
                {
                    { 99996, "yasin.susurcu@gmail.com", 2, "susurcu", "yasin", "test4" },
                    { 99997, "taha.aslan@gmail.com", 1, "aslan", "taha", "test1" }
                });

            migrationBuilder.InsertData(
                table: "Çalışanlar",
                columns: new[] { "Id", "Email", "Soyisim", "ÇalışanKonumu", "ÇalışanNo", "İsim", "Şifre" },
                values: new object[,]
                {
                    { 99998, "osman.yılmaz@gmail.com", "yılmaz", "Yönetici", 2, "osman", "test3" },
                    { 99999, "ahmet.kılıç@gmail.com", "kılıç", "Normal çalışan", 1, "ahmet", "test2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Çalışanlar");

            migrationBuilder.DropTable(
                name: "Kişiler");

            migrationBuilder.DropTable(
                name: "NormalKullanıcılars");

            migrationBuilder.DropSequence(
                name: "EC_Sequence_calısan");

            migrationBuilder.DropSequence(
                name: "EC_Sequence_kullanıcı");

            migrationBuilder.DropSequence(
                name: "KişiSequence");
        }
    }
}
