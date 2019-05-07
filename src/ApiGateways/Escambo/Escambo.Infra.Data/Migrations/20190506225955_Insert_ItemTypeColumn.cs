using Microsoft.EntityFrameworkCore.Migrations;

namespace Escambo.Infra.Data.Migrations
{
    public partial class Insert_ItemTypeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Items",
                newName: "Name");
        }
    }
}
