using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Equipment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Equipments",
                newName: "EquipmentName");

            migrationBuilder.AddColumn<bool>(
                name: "Discontinued",
                table: "Equipments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discontinued",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "EquipmentName",
                table: "Equipments",
                newName: "Name");
        }
    }
}
