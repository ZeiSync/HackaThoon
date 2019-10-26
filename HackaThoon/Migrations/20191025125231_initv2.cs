using Microsoft.EntityFrameworkCore.Migrations;

namespace HackaThoon.Migrations
{
    public partial class initv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Like",
                table: "Reviews",
                newName: "Rate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Reviews",
                newName: "Like");
        }
    }
}
