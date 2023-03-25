using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcoreDenemelerim.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_PersonOrder
                as 
                SELECT top 100 p.Name,COUNT(*) [Count] from Persons p INNER join Orders o 
                on p.PersonId=o.PersonId
                GROUP by p.Name
                Order by [Count] Desc
                                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                Drop VIEW vm_PersonOrder");
        }
    }
}
