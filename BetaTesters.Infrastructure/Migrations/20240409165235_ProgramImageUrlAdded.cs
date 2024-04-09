using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class ProgramImageUrlAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BetaPrograms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BetaPrograms");
        }
    }
}
