using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident.Migrations
{
    public partial class updates3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DieselLevel",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "ExcessiveFluidLeaksEspeciallyUnderMachine",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "SPREADEROilLeakingFlipperDamageFlipperMissingSPR",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "VisualCheckOfBeltsBeforeOperation",
                table: "RTGCheck");

            migrationBuilder.AddColumn<bool>(
                name: "AC",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Brakes",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeiselLevel",
                table: "RTGCheck",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HandbreakAndwindScreenWipers",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HornsAlarms",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HydraulicControls",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lights",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoExcessiveFluidLeaksEspeciallyUnderMachine",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RadioCommunication",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SPREADEROilLeakingSPR",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SeatBelts",
                table: "RTGCheck",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SpeedLimitOperating",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Steering",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VMT",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WindowsAreCleanAndNotDamaged",
                table: "RTGCheck",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AC",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "Brakes",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "DeiselLevel",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "HandbreakAndwindScreenWipers",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "HornsAlarms",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "HydraulicControls",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "Lights",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "NoExcessiveFluidLeaksEspeciallyUnderMachine",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "RadioCommunication",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "SPREADEROilLeakingSPR",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "SeatBelts",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "SpeedLimitOperating",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "Steering",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "VMT",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "WindowsAreCleanAndNotDamaged",
                table: "RTGCheck");

            migrationBuilder.AddColumn<string>(
                name: "DieselLevel",
                table: "RTGCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ExcessiveFluidLeaksEspeciallyUnderMachine",
                table: "RTGCheck",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SPREADEROilLeakingFlipperDamageFlipperMissingSPR",
                table: "RTGCheck",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VisualCheckOfBeltsBeforeOperation",
                table: "RTGCheck",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
