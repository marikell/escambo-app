using Microsoft.EntityFrameworkCore.Migrations;

namespace Escambo.Infra.Data.Migrations
{
    public partial class Hired_Field_Tb_Item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hired",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hired",
                table: "Items");
        }
    }
}
