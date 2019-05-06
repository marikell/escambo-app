using Microsoft.EntityFrameworkCore.Migrations;

namespace Escambo.Infra.Data.Migrations
{
    public partial class FK_User_Id_Itemcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Items",
                newName: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_user_id",
                table: "Items",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_user_id",
                table: "Items",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_user_id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_user_id",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Items",
                newName: "UserId");
        }
    }
}
