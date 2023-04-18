using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessKatman.Migrations
{
    public partial class mig_remove_destination_from_visit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Visits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
