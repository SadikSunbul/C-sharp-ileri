using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcoreDenemelerim.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_Deneme
                    as
                    SELECT 
                    p.Name,
                    o.[Description]
                    from Persons p INNER JOIN orders o on p.PersonId=o.PersonId"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                Drop VIEW vm_Deneme" );
        }
    }
}
