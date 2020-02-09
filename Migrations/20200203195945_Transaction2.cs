using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyLightWeb.Migrations
{
    public partial class Transaction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Transaction_TransactionID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetail_Assets_AssetID",
                table: "TransactionDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetail_Equipments_EquipmentID",
                table: "TransactionDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetail_Transaction_TransactionID",
                table: "TransactionDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDetail",
                table: "TransactionDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "TransactionDetail",
                newName: "TransactionDetails");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetail_TransactionID",
                table: "TransactionDetails",
                newName: "IX_TransactionDetails_TransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetail_EquipmentID",
                table: "TransactionDetails",
                newName: "IX_TransactionDetails_EquipmentID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetail_AssetID",
                table: "TransactionDetails",
                newName: "IX_TransactionDetails_AssetID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDetails",
                table: "TransactionDetails",
                column: "TransactionDetailID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Transactions_TransactionID",
                table: "Assets",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Assets_AssetID",
                table: "TransactionDetails",
                column: "AssetID",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Equipments_EquipmentID",
                table: "TransactionDetails",
                column: "EquipmentID",
                principalTable: "Equipments",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionID",
                table: "TransactionDetails",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Transactions_TransactionID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Assets_AssetID",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Equipments_EquipmentID",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Transactions_TransactionID",
                table: "TransactionDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionDetails",
                table: "TransactionDetails");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "TransactionDetails",
                newName: "TransactionDetail");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetails_TransactionID",
                table: "TransactionDetail",
                newName: "IX_TransactionDetail_TransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetails_EquipmentID",
                table: "TransactionDetail",
                newName: "IX_TransactionDetail_EquipmentID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionDetails_AssetID",
                table: "TransactionDetail",
                newName: "IX_TransactionDetail_AssetID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionDetail",
                table: "TransactionDetail",
                column: "TransactionDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Transaction_TransactionID",
                table: "Assets",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetail_Assets_AssetID",
                table: "TransactionDetail",
                column: "AssetID",
                principalTable: "Assets",
                principalColumn: "AssetID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetail_Equipments_EquipmentID",
                table: "TransactionDetail",
                column: "EquipmentID",
                principalTable: "Equipments",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetail_Transaction_TransactionID",
                table: "TransactionDetail",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
