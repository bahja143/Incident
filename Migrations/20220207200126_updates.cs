using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECHCheck_Shifts_ShiftId",
                table: "ECHCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_ForkliftCheck_Shifts_ShiftId",
                table: "ForkliftCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_ITVCheck_Shifts_ShiftId",
                table: "ITVCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_MCCheck_Shifts_ShiftId",
                table: "MCCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_MHCCheck_Shifts_ShiftId",
                table: "MHCCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_RSCheck_Shifts_ShiftId",
                table: "RSCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGCheck_Shifts_ShiftId",
                table: "RTGCheck");

            migrationBuilder.DropIndex(
                name: "IX_RTGCheck_ShiftId",
                table: "RTGCheck");

            migrationBuilder.DropIndex(
                name: "IX_RSCheck_ShiftId",
                table: "RSCheck");

            migrationBuilder.DropIndex(
                name: "IX_MHCCheck_ShiftId",
                table: "MHCCheck");

            migrationBuilder.DropIndex(
                name: "IX_MCCheck_ShiftId",
                table: "MCCheck");

            migrationBuilder.DropIndex(
                name: "IX_ITVCheck_ShiftId",
                table: "ITVCheck");

            migrationBuilder.DropIndex(
                name: "IX_ForkliftCheck_ShiftId",
                table: "ForkliftCheck");

            migrationBuilder.DropIndex(
                name: "IX_ECHCheck_ShiftId",
                table: "ECHCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "RSCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "MHCCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "MCCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "ITVCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "ForkliftCheck");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "ECHCheck");

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "RTGCheck",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "RSCheck",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "MHCCheck",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "MCCheck",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "ITVCheck",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "ForkliftCheck",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TailLightsAreWorking",
                table: "ECHCheck",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SPREADEROilLeakingSPR",
                table: "ECHCheck",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Mirrors",
                table: "ECHCheck",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FloodLightsAreWorking",
                table: "ECHCheck",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FireExtingisher",
                table: "ECHCheck",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shift",
                table: "ECHCheck",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shift",
                table: "RTGCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "RSCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "MHCCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "MCCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "ITVCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "ForkliftCheck");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "ECHCheck");

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "RTGCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "RSCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "MHCCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "MCCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "ITVCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "ForkliftCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TailLightsAreWorking",
                table: "ECHCheck",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "SPREADEROilLeakingSPR",
                table: "ECHCheck",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Mirrors",
                table: "ECHCheck",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "FloodLightsAreWorking",
                table: "ECHCheck",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "FireExtingisher",
                table: "ECHCheck",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "ECHCheck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RTGCheck_ShiftId",
                table: "RTGCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_RSCheck_ShiftId",
                table: "RSCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_MHCCheck_ShiftId",
                table: "MHCCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_MCCheck_ShiftId",
                table: "MCCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ITVCheck_ShiftId",
                table: "ITVCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ForkliftCheck_ShiftId",
                table: "ForkliftCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ECHCheck_ShiftId",
                table: "ECHCheck",
                column: "ShiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_ECHCheck_Shifts_ShiftId",
                table: "ECHCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForkliftCheck_Shifts_ShiftId",
                table: "ForkliftCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITVCheck_Shifts_ShiftId",
                table: "ITVCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MCCheck_Shifts_ShiftId",
                table: "MCCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MHCCheck_Shifts_ShiftId",
                table: "MHCCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSCheck_Shifts_ShiftId",
                table: "RSCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGCheck_Shifts_ShiftId",
                table: "RTGCheck",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
