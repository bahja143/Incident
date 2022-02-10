using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Incident.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ECH",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forklift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forklift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MHC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MHC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RTG",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ECHCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HydraulicControls = table.Column<bool>(nullable: false),
                    Steering = table.Column<bool>(nullable: false),
                    CheckWindowsAreCleanAndNotDamaged = table.Column<bool>(nullable: false),
                    HandBreakAndWindscreenWipers = table.Column<bool>(nullable: false),
                    VMT = table.Column<bool>(nullable: false),
                    RadioCommunication = table.Column<bool>(nullable: false),
                    Lights = table.Column<bool>(nullable: false),
                    SpeedLimitOperating = table.Column<bool>(nullable: false),
                    AC = table.Column<bool>(nullable: false),
                    HornsAndAlarms = table.Column<bool>(nullable: false),
                    SeatBelts = table.Column<bool>(nullable: false),
                    Brakes = table.Column<bool>(nullable: false),
                    NoTyreDamageOrInsuficientInflation = table.Column<bool>(nullable: false),
                    NoWheelsLooseNuts = table.Column<bool>(nullable: false),
                    NoAccidentDamageOrFrameIncludingAttachements = table.Column<bool>(nullable: false),
                    NoExcessiveFluidLeaksEspeciallyMnderMachine = table.Column<bool>(nullable: false),
                    SPREADEROilLeakingSPR = table.Column<string>(nullable: true),
                    FloodLightsAreWorking = table.Column<string>(nullable: true),
                    TailLightsAreWorking = table.Column<string>(nullable: true),
                    Mirrors = table.Column<string>(nullable: true),
                    FireExtingisher = table.Column<string>(nullable: true),
                    DeiselLevel = table.Column<string>(nullable: true),
                    HMR = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ECHId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECHCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ECHCheck_ECH_ECHId",
                        column: x => x.ECHId,
                        principalTable: "ECH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ECHCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ECHCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForkliftCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HydraulicControls = table.Column<bool>(nullable: false),
                    Steering = table.Column<bool>(nullable: false),
                    HandBreak = table.Column<bool>(nullable: false),
                    Lights = table.Column<bool>(nullable: false),
                    HornsAndAlarms = table.Column<bool>(nullable: false),
                    SeatBelts = table.Column<bool>(nullable: false),
                    Brakes = table.Column<bool>(nullable: false),
                    NoTyreDamageOrInsuficientInflation = table.Column<bool>(nullable: false),
                    NoWheelsLooseNuts = table.Column<bool>(nullable: false),
                    NoAccidentDamageOrFrameIncludingAttachements = table.Column<bool>(nullable: false),
                    NoExcessiveFluidLeaksEspeciallyUnderMachine = table.Column<bool>(nullable: false),
                    FloodLightsAreWorking = table.Column<bool>(nullable: false),
                    TailLightsAreWorking = table.Column<bool>(nullable: false),
                    Mirrors = table.Column<bool>(nullable: false),
                    RotatingAmbersLightsAreWorking = table.Column<bool>(nullable: false),
                    FireExtingisher = table.Column<bool>(nullable: false),
                    DeiselLevel = table.Column<string>(nullable: true),
                    HMR = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ForkliftId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForkliftCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForkliftCheck_Forklift_ForkliftId",
                        column: x => x.ForkliftId,
                        principalTable: "Forklift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForkliftCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForkliftCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITVCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HydraulicControls = table.Column<bool>(nullable: false),
                    Steering = table.Column<bool>(nullable: false),
                    CheckWindowsAreCleanAndNotDamaged = table.Column<bool>(nullable: false),
                    HandBreakAndWindscreenWipers = table.Column<bool>(nullable: false),
                    VMT = table.Column<bool>(nullable: false),
                    RadioCommunication = table.Column<bool>(nullable: false),
                    Ensure5thwheelAtCorrectHeight = table.Column<bool>(nullable: false),
                    Lights = table.Column<bool>(nullable: false),
                    SpeedLimitOperating = table.Column<bool>(nullable: false),
                    AC = table.Column<bool>(nullable: false),
                    HornsAndAlarms = table.Column<bool>(nullable: false),
                    SeatBelts = table.Column<bool>(nullable: false),
                    Brakes = table.Column<bool>(nullable: false),
                    NoTyreDamageOrInsuficientInflation = table.Column<bool>(nullable: false),
                    NoWheelsLooseNuts = table.Column<bool>(nullable: false),
                    NoAccidentDamageOrFrameIncludingAttachements = table.Column<bool>(nullable: false),
                    NoExcessiveFluidLeaksEspeciallyMnderMachine = table.Column<bool>(nullable: false),
                    FloodLightsAreWorking = table.Column<bool>(nullable: false),
                    TailLightsAreWorking = table.Column<bool>(nullable: false),
                    Mirrors = table.Column<bool>(nullable: false),
                    TurntableLockingBarInFullyLatchedPosition = table.Column<bool>(nullable: false),
                    TrailerSuzieHosesAndCableSecure = table.Column<bool>(nullable: false),
                    TrailerLegsLiftedToFullHeight = table.Column<bool>(nullable: false),
                    FireExtingisher = table.Column<bool>(nullable: false),
                    DeiselLevel = table.Column<string>(nullable: true),
                    HMR = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ITVId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITVCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITVCheck_ITV_ITVId",
                        column: x => x.ITVId,
                        principalTable: "ITV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITVCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITVCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MCCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineFluidLevelCorrect = table.Column<bool>(nullable: false),
                    HydraulicFluidLevelCorrect = table.Column<bool>(nullable: false),
                    HydraulicSystemExhibitsNoApparentWeepingOrLeaks = table.Column<bool>(nullable: false),
                    AirSystemexhibitsNoAudibleLeaks = table.Column<bool>(nullable: false),
                    TyrePressureAccetableAndTireNotDamaged = table.Column<bool>(nullable: false),
                    TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder = table.Column<bool>(nullable: false),
                    WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl = table.Column<bool>(nullable: false),
                    ReevingCorrect = table.Column<bool>(nullable: false),
                    WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing = table.Column<bool>(nullable: false),
                    AllAndHookAreFreeToSwivelAndRotate = table.Column<bool>(nullable: false),
                    OutriggerFloatsSecuredWithPadIn = table.Column<bool>(nullable: false),
                    Cab = table.Column<bool>(nullable: false),
                    HandrailsInPlaceAndNotDamaged = table.Column<bool>(nullable: false),
                    OperatorManualInVehicle = table.Column<bool>(nullable: false),
                    LoadChartLegibleAndVisibleToOperator = table.Column<bool>(nullable: false),
                    HandSignalChartVisibleToWorkers = table.Column<bool>(nullable: false),
                    ChargedFireExtinguisherInplace = table.Column<bool>(nullable: false),
                    CabGlassNotCrackedAndWipersAreFunctional = table.Column<bool>(nullable: false),
                    LoadMomentIndicatorOperational = table.Column<bool>(nullable: false),
                    DrumRotationIndicatorFunctioning = table.Column<bool>(nullable: false),
                    BoomLengthIndicatorFunctioning = table.Column<bool>(nullable: false),
                    BoomAngleIndicatorFunctioning = table.Column<bool>(nullable: false),
                    EngineHydraulicAirElectricalOilPressureTemperatureAandFuel = table.Column<bool>(nullable: false),
                    CorrectCounterweightForTheLoad = table.Column<bool>(nullable: false),
                    MainHoistControlFunctioning = table.Column<bool>(nullable: false),
                    AntiTwoBlockInLaceAndFunctioning = table.Column<bool>(nullable: false),
                    SwingBrake = table.Column<bool>(nullable: false),
                    AuxiliaryHoistControlFunctioning = table.Column<bool>(nullable: false),
                    DieselFuelLeakage = table.Column<bool>(nullable: false),
                    EngineHourMeter = table.Column<string>(nullable: true),
                    FuelLevelReading = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    MCId = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MCCheck_MC_MCId",
                        column: x => x.MCId,
                        principalTable: "MC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MCCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MCCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MHCCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineFluidLevelCorrect = table.Column<bool>(nullable: false),
                    HydraulicFluidLevelCorrect = table.Column<bool>(nullable: false),
                    HydraulicSystemExhibitsNoApparentWeepingOrLeaks = table.Column<bool>(nullable: false),
                    AirSystemexhibitsNoAudibleLeaks = table.Column<bool>(nullable: false),
                    TyrePressureAccetableAndTireNotDamaged = table.Column<bool>(nullable: false),
                    TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder = table.Column<bool>(nullable: false),
                    WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl = table.Column<bool>(nullable: false),
                    ReevingCorrect = table.Column<bool>(nullable: false),
                    WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing = table.Column<bool>(nullable: false),
                    AllAndHookAreFreeToSwivelAndRotate = table.Column<bool>(nullable: false),
                    OutriggerFloatsSecuredWithPadIn = table.Column<bool>(nullable: false),
                    Cab = table.Column<bool>(nullable: false),
                    HandrailsInPlaceAndNotDamaged = table.Column<bool>(nullable: false),
                    OperatorManualInVehicle = table.Column<bool>(nullable: false),
                    LoadChartLegibleAndVisibleToOperator = table.Column<bool>(nullable: false),
                    HandSignalChartVisibleToWorkers = table.Column<bool>(nullable: false),
                    ChargedFireExtinguisherInplace = table.Column<bool>(nullable: false),
                    CabGlassNotCrackedAndWipersAreFunctional = table.Column<bool>(nullable: false),
                    LoadMomentIndicatorOperational = table.Column<bool>(nullable: false),
                    DrumRotationIndicatorFunctioning = table.Column<bool>(nullable: false),
                    BoomLengthIndicatorFunctioning = table.Column<bool>(nullable: false),
                    BoomAngleIndicatorFunctioning = table.Column<bool>(nullable: false),
                    EngineHydraulicAirElectricalOilPressureTemperatureAandFuel = table.Column<bool>(nullable: false),
                    CorrectCounterweightForTheLoad = table.Column<bool>(nullable: false),
                    MainHoistControlFunctioning = table.Column<bool>(nullable: false),
                    AntiTwoBlockInLaceAndFunctioning = table.Column<bool>(nullable: false),
                    SwingBrake = table.Column<bool>(nullable: false),
                    AuxiliaryHoistControlFunctioning = table.Column<bool>(nullable: false),
                    DieselFuelLeakage = table.Column<bool>(nullable: false),
                    EngineHourMeter = table.Column<string>(nullable: true),
                    FuelLevelReading = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    MHCId = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MHCCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MHCCheck_MHC_MHCId",
                        column: x => x.MHCId,
                        principalTable: "MHC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MHCCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MHCCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HydraulicControls = table.Column<bool>(nullable: false),
                    Steering = table.Column<bool>(nullable: false),
                    CheckWindowsAreCleanAndNotDamaged = table.Column<bool>(nullable: false),
                    HandBreakAndWindscreenWipers = table.Column<bool>(nullable: false),
                    VMT = table.Column<bool>(nullable: false),
                    RadioCommunication = table.Column<bool>(nullable: false),
                    Lights = table.Column<bool>(nullable: false),
                    SpeedLimitOperating = table.Column<bool>(nullable: false),
                    AC = table.Column<bool>(nullable: false),
                    HornsAndAlarms = table.Column<bool>(nullable: false),
                    SeatBelts = table.Column<bool>(nullable: false),
                    Brakes = table.Column<bool>(nullable: false),
                    NoTyreDamageOrInsuficientInflation = table.Column<bool>(nullable: false),
                    NoWheelsLooseNuts = table.Column<bool>(nullable: false),
                    NoAccidentDamageOrFrameIncludingAttachements = table.Column<bool>(nullable: false),
                    NoExcessiveFluidLeaksEspeciallyMnderMachine = table.Column<bool>(nullable: false),
                    SPREADEROilLeakingSPR = table.Column<string>(nullable: true),
                    FloodLightsAreWorking = table.Column<string>(nullable: true),
                    TailLightsAreWorking = table.Column<string>(nullable: true),
                    Mirrors = table.Column<string>(nullable: true),
                    FireExtingisher = table.Column<string>(nullable: true),
                    DeiselLevel = table.Column<string>(nullable: true),
                    HMR = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RSId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RSCheck_RS_RSId",
                        column: x => x.RSId,
                        principalTable: "RS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RTGCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoTyreDamageOrInsuficientInflation = table.Column<string>(nullable: true),
                    NoWheelsLooseNuts = table.Column<string>(nullable: true),
                    SPREADEROilLeakingFlipperDamageFlipperMissingSPR = table.Column<string>(nullable: true),
                    NoAccidentDamageOrFrameIncludingAttachements = table.Column<string>(nullable: true),
                    VisualCheckOfBeltsBeforeOperation = table.Column<string>(nullable: true),
                    ExcessiveFluidLeaksEspeciallyUnderMachine = table.Column<string>(nullable: true),
                    FloodLightsAreWorking = table.Column<string>(nullable: true),
                    TailLightsAreWorking = table.Column<string>(nullable: true),
                    Mirrors = table.Column<string>(nullable: true),
                    FireExtingisher = table.Column<string>(nullable: true),
                    DieselLevel = table.Column<string>(nullable: true),
                    HMR = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RTGId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTGCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTGCheck_RTG_RTGId",
                        column: x => x.RTGId,
                        principalTable: "RTG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RTGCheck_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RTGCheck_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECHCheck_ECHId",
                table: "ECHCheck",
                column: "ECHId");

            migrationBuilder.CreateIndex(
                name: "IX_ECHCheck_ShiftId",
                table: "ECHCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ECHCheck_UserId",
                table: "ECHCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForkliftCheck_ForkliftId",
                table: "ForkliftCheck",
                column: "ForkliftId");

            migrationBuilder.CreateIndex(
                name: "IX_ForkliftCheck_ShiftId",
                table: "ForkliftCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ForkliftCheck_UserId",
                table: "ForkliftCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ITVCheck_ITVId",
                table: "ITVCheck",
                column: "ITVId");

            migrationBuilder.CreateIndex(
                name: "IX_ITVCheck_ShiftId",
                table: "ITVCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ITVCheck_UserId",
                table: "ITVCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MCCheck_MCId",
                table: "MCCheck",
                column: "MCId");

            migrationBuilder.CreateIndex(
                name: "IX_MCCheck_ShiftId",
                table: "MCCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_MCCheck_UserId",
                table: "MCCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MHCCheck_MHCId",
                table: "MHCCheck",
                column: "MHCId");

            migrationBuilder.CreateIndex(
                name: "IX_MHCCheck_ShiftId",
                table: "MHCCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_MHCCheck_UserId",
                table: "MHCCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RSCheck_RSId",
                table: "RSCheck",
                column: "RSId");

            migrationBuilder.CreateIndex(
                name: "IX_RSCheck_ShiftId",
                table: "RSCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_RSCheck_UserId",
                table: "RSCheck",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGCheck_RTGId",
                table: "RTGCheck",
                column: "RTGId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGCheck_ShiftId",
                table: "RTGCheck",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGCheck_UserId",
                table: "RTGCheck",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECHCheck");

            migrationBuilder.DropTable(
                name: "ForkliftCheck");

            migrationBuilder.DropTable(
                name: "ITVCheck");

            migrationBuilder.DropTable(
                name: "MCCheck");

            migrationBuilder.DropTable(
                name: "MHCCheck");

            migrationBuilder.DropTable(
                name: "RSCheck");

            migrationBuilder.DropTable(
                name: "RTGCheck");

            migrationBuilder.DropTable(
                name: "ECH");

            migrationBuilder.DropTable(
                name: "Forklift");

            migrationBuilder.DropTable(
                name: "ITV");

            migrationBuilder.DropTable(
                name: "MC");

            migrationBuilder.DropTable(
                name: "MHC");

            migrationBuilder.DropTable(
                name: "RS");

            migrationBuilder.DropTable(
                name: "RTG");

            migrationBuilder.DropTable(
                name: "Shifts");
        }
    }
}
