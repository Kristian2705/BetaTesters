using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class FixedBalanceField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "decimal(18,2)",
                table: "Transactions",
                newName: "Money");

            migrationBuilder.RenameColumn(
                name: "decimal(18,2)",
                table: "Tasks",
                newName: "Reward");

            migrationBuilder.RenameColumn(
                name: "decimal(18,2)",
                table: "Payments",
                newName: "Money");

            migrationBuilder.RenameColumn(
                name: "decimal(18,2)",
                table: "AspNetUsers",
                newName: "Balance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Money",
                table: "Transactions",
                newName: "decimal(18,2)");

            migrationBuilder.RenameColumn(
                name: "Reward",
                table: "Tasks",
                newName: "decimal(18,2)");

            migrationBuilder.RenameColumn(
                name: "Money",
                table: "Payments",
                newName: "decimal(18,2)");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "AspNetUsers",
                newName: "decimal(18,2)");
        }
    }
}
