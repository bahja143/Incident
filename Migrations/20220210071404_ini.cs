using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tellphone",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Tellphone",
                table: "Users");
        }
    }
}
