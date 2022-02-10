using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident.Migrations
{
    public partial class AddSnapshotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SnapShot",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    IncidentType = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    PeopleInvolved = table.Column<string>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    Responsible = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnapShot", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnapShot");
        }
    }
}
