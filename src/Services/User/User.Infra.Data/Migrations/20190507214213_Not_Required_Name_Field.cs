using Microsoft.EntityFrameworkCore.Migrations;

namespace User.Infra.Data.Migrations
{
    public partial class Not_Required_Name_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 140);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 140,
                oldNullable: true);
        }
    }
}
