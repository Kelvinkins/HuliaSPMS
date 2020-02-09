using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Equipment1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackInventory",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "AssetType",
                table: "Assets",
                newName: "EquipmentID");

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    EquipmentType = table.Column<string>(nullable: true),
                    TrackInventory = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_EquipmentID",
                table: "Assets",
                column: "EquipmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Equipments_EquipmentID",
                table: "Assets",
                column: "EquipmentID",
                principalTable: "Equipments",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Equipments_EquipmentID",
                table: "Assets");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Assets_EquipmentID",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "Assets",
                newName: "AssetType");

            migrationBuilder.AddColumn<bool>(
                name: "TrackInventory",
                table: "Assets",
                nullable: false,
                defaultValue: false);
        }
    }
}
