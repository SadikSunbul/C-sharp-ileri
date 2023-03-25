using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcoreDenemelerim.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"

                    CREATE PROC yeniProsedur
                    @PersonId INT
                    AS
                    BEGIN
                    SELECT Name from Persons where Persons.PersonId=@PersonId
                    END

                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" Drop PROC yeniProsedur");
        }
    }
}
