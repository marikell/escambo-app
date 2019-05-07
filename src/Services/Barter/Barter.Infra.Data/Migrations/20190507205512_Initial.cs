using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Barter.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barters",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    item_offered_id = table.Column<Guid>(nullable: false),
                    item_received_id = table.Column<Guid>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    finished = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barters", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barters");
        }
    }
}
