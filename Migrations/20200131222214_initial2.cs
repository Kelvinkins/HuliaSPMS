using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnIdentified",
                table: "Assets",
                newName: "TrackInventory");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GpsProtocol",
                table: "Assets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "GpsProtocol",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "TrackInventory",
                table: "Assets",
                newName: "UnIdentified");
        }
    }
}
