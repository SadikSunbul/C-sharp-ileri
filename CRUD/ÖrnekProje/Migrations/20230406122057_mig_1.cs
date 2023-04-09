using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ÖrnekProje.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "A1Sequence");

            migrationBuilder.CreateSequence(
                name: "deger",
                startValue: 900L);

            migrationBuilder.CreateTable(
                name: "A1",
                columns: table => new
                {
                    AId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [A1Sequence]"),
                    Aacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A1", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "Asınıfıs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bacıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cacıklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asınıfıs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B1",
                columns: table => new
                {
                    AId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [A1Sequence]"),
                    Aacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B1", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "C1",
                columns: table => new
                {
                    AId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [A1Sequence]"),
                    Aacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C1", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "Hesaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapAdı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hesaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kişiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kişiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kurslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KursAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sınıflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sınıfno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sınıflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "xsınıfı",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Xacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xsınıfı", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HesapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanıcılar_Hesaplar_HesapId",
                        column: x => x.HesapId,
                        principalTable: "Hesaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kişikurslar",
                columns: table => new
                {
                    KişiId = table.Column<int>(type: "int", nullable: false),
                    KursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kişikurslar", x => new { x.KursId, x.KişiId });
                    table.ForeignKey(
                        name: "FK_Kişikurslar_Kişiler_KişiId",
                        column: x => x.KişiId,
                        principalTable: "Kişiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kişikurslar_Kurslar_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Öğrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sequences = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR deger"),
                    Soyadı = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SınıfNo = table.Column<int>(type: "int", nullable: false),
                    KayıtZamanı = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 4, 6, 15, 20, 57, 863, DateTimeKind.Local).AddTicks(9324))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Öğrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Öğrenciler_Sınıflar_SınıfNo",
                        column: x => x.SınıfNo,
                        principalTable: "Sınıflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ysınıfı",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Yacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ysınıfı", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ysınıfı_xsınıfı_Id",
                        column: x => x.Id,
                        principalTable: "xsınıfı",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zsınıfı",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Zacıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zsınıfı", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zsınıfı_Ysınıfı_Id",
                        column: x => x.Id,
                        principalTable: "Ysınıfı",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kişikurslar_KişiId",
                table: "Kişikurslar",
                column: "KişiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_HesapId",
                table: "Kullanıcılar",
                column: "HesapId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Öğrenciler_Adi_Soyadı",
                table: "Öğrenciler",
                columns: new[] { "Adi", "Soyadı" });

            migrationBuilder.CreateIndex(
                name: "IX_Öğrenciler_SınıfNo",
                table: "Öğrenciler",
                column: "SınıfNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A1");

            migrationBuilder.DropTable(
                name: "Asınıfıs");

            migrationBuilder.DropTable(
                name: "B1");

            migrationBuilder.DropTable(
                name: "C1");

            migrationBuilder.DropTable(
                name: "Kişikurslar");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Öğrenciler");

            migrationBuilder.DropTable(
                name: "Zsınıfı");

            migrationBuilder.DropTable(
                name: "Kişiler");

            migrationBuilder.DropTable(
                name: "Kurslar");

            migrationBuilder.DropTable(
                name: "Hesaplar");

            migrationBuilder.DropTable(
                name: "Sınıflar");

            migrationBuilder.DropTable(
                name: "Ysınıfı");

            migrationBuilder.DropTable(
                name: "xsınıfı");

            migrationBuilder.DropSequence(
                name: "A1Sequence");

            migrationBuilder.DropSequence(
                name: "deger");
        }
    }
}
