using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessKatman.Migrations
{
    public partial class mig_add_relation_destination_visit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DestinationID",
                table: "Visits",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Destinations_DestinationID",
                table: "Visits",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Destinations_DestinationID",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_DestinationID",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Visits");
        }
    }
}
