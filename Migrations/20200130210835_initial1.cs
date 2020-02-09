using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetAddress",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetAddressTwo",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "FamilyName",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "DateCreaeted",
                table: "Assets",
                newName: "DateCreated");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Assets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Assets",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Assets",
                newName: "DateCreaeted");

            migrationBuilder.AddColumn<string>(
                name: "AssetAddress",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetAddressTwo",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyName",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Assets",
                nullable: true);
        }
    }
}
