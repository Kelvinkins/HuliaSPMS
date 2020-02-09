using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Custodian1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustodianID",
                table: "Assets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Custodians",
                columns: table => new
                {
                    CustodianID = table.Column<string>(nullable: false),
                    CustodianName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    CustodianType = table.Column<string>(nullable: true),
                    Discontinued = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custodians", x => x.CustodianID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_CustodianID",
                table: "Assets",
                column: "CustodianID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Custodians_CustodianID",
                table: "Assets",
                column: "CustodianID",
                principalTable: "Custodians",
                principalColumn: "CustodianID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Custodians_CustodianID",
                table: "Assets");

            migrationBuilder.DropTable(
                name: "Custodians");

            migrationBuilder.DropIndex(
                name: "IX_Assets_CustodianID",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "CustodianID",
                table: "Assets");
        }
    }
}
