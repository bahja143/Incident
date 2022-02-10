﻿// <auto-generated />
using System;
using Incident.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Incident.Migrations
{
    [DbContext(typeof(IncidentDbContext))]
    [Migration("20220207200126_updates")]
    partial class updates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Incident.Modal.ECH", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ECH");
                });

            modelBuilder.Entity("Incident.Modal.ECHCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AC")
                        .HasColumnType("bit");

                    b.Property<bool>("Brakes")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckWindowsAreCleanAndNotDamaged")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeiselLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ECHId")
                        .HasColumnType("int");

                    b.Property<bool>("FireExtingisher")
                        .HasColumnType("bit");

                    b.Property<bool>("FloodLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<string>("HMR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandBreakAndWindscreenWipers")
                        .HasColumnType("bit");

                    b.Property<bool>("HornsAndAlarms")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicControls")
                        .HasColumnType("bit");

                    b.Property<bool>("Lights")
                        .HasColumnType("bit");

                    b.Property<bool>("Mirrors")
                        .HasColumnType("bit");

                    b.Property<bool>("NoAccidentDamageOrFrameIncludingAttachements")
                        .HasColumnType("bit");

                    b.Property<bool>("NoExcessiveFluidLeaksEspeciallyMnderMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("NoTyreDamageOrInsuficientInflation")
                        .HasColumnType("bit");

                    b.Property<bool>("NoWheelsLooseNuts")
                        .HasColumnType("bit");

                    b.Property<bool>("RadioCommunication")
                        .HasColumnType("bit");

                    b.Property<bool>("SPREADEROilLeakingSPR")
                        .HasColumnType("bit");

                    b.Property<bool>("SeatBelts")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SpeedLimitOperating")
                        .HasColumnType("bit");

                    b.Property<bool>("Steering")
                        .HasColumnType("bit");

                    b.Property<bool>("TailLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("VMT")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ECHId");

                    b.HasIndex("UserId");

                    b.ToTable("ECHCheck");
                });

            modelBuilder.Entity("Incident.Modal.Forklift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Forklift");
                });

            modelBuilder.Entity("Incident.Modal.ForkliftCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Brakes")
                        .HasColumnType("bit");

                    b.Property<string>("DeiselLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FireExtingisher")
                        .HasColumnType("bit");

                    b.Property<bool>("FloodLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<int>("ForkliftId")
                        .HasColumnType("int");

                    b.Property<string>("HMR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandBreak")
                        .HasColumnType("bit");

                    b.Property<bool>("HornsAndAlarms")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicControls")
                        .HasColumnType("bit");

                    b.Property<bool>("Lights")
                        .HasColumnType("bit");

                    b.Property<bool>("Mirrors")
                        .HasColumnType("bit");

                    b.Property<bool>("NoAccidentDamageOrFrameIncludingAttachements")
                        .HasColumnType("bit");

                    b.Property<bool>("NoExcessiveFluidLeaksEspeciallyUnderMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("NoTyreDamageOrInsuficientInflation")
                        .HasColumnType("bit");

                    b.Property<bool>("NoWheelsLooseNuts")
                        .HasColumnType("bit");

                    b.Property<bool>("RotatingAmbersLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<bool>("SeatBelts")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Steering")
                        .HasColumnType("bit");

                    b.Property<bool>("TailLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ForkliftId");

                    b.HasIndex("UserId");

                    b.ToTable("ForkliftCheck");
                });

            modelBuilder.Entity("Incident.Modal.ITV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ITV");
                });

            modelBuilder.Entity("Incident.Modal.ITVCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AC")
                        .HasColumnType("bit");

                    b.Property<bool>("Brakes")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckWindowsAreCleanAndNotDamaged")
                        .HasColumnType("bit");

                    b.Property<string>("DeiselLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ensure5thwheelAtCorrectHeight")
                        .HasColumnType("bit");

                    b.Property<bool>("FireExtingisher")
                        .HasColumnType("bit");

                    b.Property<bool>("FloodLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<string>("HMR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandBreakAndWindscreenWipers")
                        .HasColumnType("bit");

                    b.Property<bool>("HornsAndAlarms")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicControls")
                        .HasColumnType("bit");

                    b.Property<int>("ITVId")
                        .HasColumnType("int");

                    b.Property<bool>("Lights")
                        .HasColumnType("bit");

                    b.Property<bool>("Mirrors")
                        .HasColumnType("bit");

                    b.Property<bool>("NoAccidentDamageOrFrameIncludingAttachements")
                        .HasColumnType("bit");

                    b.Property<bool>("NoExcessiveFluidLeaksEspeciallyMnderMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("NoTyreDamageOrInsuficientInflation")
                        .HasColumnType("bit");

                    b.Property<bool>("NoWheelsLooseNuts")
                        .HasColumnType("bit");

                    b.Property<bool>("RadioCommunication")
                        .HasColumnType("bit");

                    b.Property<bool>("SeatBelts")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SpeedLimitOperating")
                        .HasColumnType("bit");

                    b.Property<bool>("Steering")
                        .HasColumnType("bit");

                    b.Property<bool>("TailLightsAreWorking")
                        .HasColumnType("bit");

                    b.Property<bool>("TrailerLegsLiftedToFullHeight")
                        .HasColumnType("bit");

                    b.Property<bool>("TrailerSuzieHosesAndCableSecure")
                        .HasColumnType("bit");

                    b.Property<bool>("TurntableLockingBarInFullyLatchedPosition")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("VMT")
                        .HasColumnType("bit");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ITVId");

                    b.HasIndex("UserId");

                    b.ToTable("ITVCheck");
                });

            modelBuilder.Entity("Incident.Modal.MC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MC");
                });

            modelBuilder.Entity("Incident.Modal.MCCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AirSystemexhibitsNoAudibleLeaks")
                        .HasColumnType("bit");

                    b.Property<bool>("AllAndHookAreFreeToSwivelAndRotate")
                        .HasColumnType("bit");

                    b.Property<bool>("AntiTwoBlockInLaceAndFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("AuxiliaryHoistControlFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("BoomAngleIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("BoomLengthIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("Cab")
                        .HasColumnType("bit");

                    b.Property<bool>("CabGlassNotCrackedAndWipersAreFunctional")
                        .HasColumnType("bit");

                    b.Property<bool>("ChargedFireExtinguisherInplace")
                        .HasColumnType("bit");

                    b.Property<bool>("CorrectCounterweightForTheLoad")
                        .HasColumnType("bit");

                    b.Property<bool>("DieselFuelLeakage")
                        .HasColumnType("bit");

                    b.Property<bool>("DrumRotationIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("EngineFluidLevelCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("EngineHourMeter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EngineHydraulicAirElectricalOilPressureTemperatureAandFuel")
                        .HasColumnType("bit");

                    b.Property<string>("FuelLevelReading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandSignalChartVisibleToWorkers")
                        .HasColumnType("bit");

                    b.Property<bool>("HandrailsInPlaceAndNotDamaged")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicFluidLevelCorrect")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicSystemExhibitsNoApparentWeepingOrLeaks")
                        .HasColumnType("bit");

                    b.Property<bool>("LoadChartLegibleAndVisibleToOperator")
                        .HasColumnType("bit");

                    b.Property<bool>("LoadMomentIndicatorOperational")
                        .HasColumnType("bit");

                    b.Property<int>("MCId")
                        .HasColumnType("int");

                    b.Property<bool>("MainHoistControlFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("OperatorManualInVehicle")
                        .HasColumnType("bit");

                    b.Property<bool>("OutriggerFloatsSecuredWithPadIn")
                        .HasColumnType("bit");

                    b.Property<bool>("ReevingCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SwingBrake")
                        .HasColumnType("bit");

                    b.Property<bool>("TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder")
                        .HasColumnType("bit");

                    b.Property<bool>("TyrePressureAccetableAndTireNotDamaged")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing")
                        .HasColumnType("bit");

                    b.Property<bool>("WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MCId");

                    b.HasIndex("UserId");

                    b.ToTable("MCCheck");
                });

            modelBuilder.Entity("Incident.Modal.MHC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MHC");
                });

            modelBuilder.Entity("Incident.Modal.MHCCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AirSystemexhibitsNoAudibleLeaks")
                        .HasColumnType("bit");

                    b.Property<bool>("AllAndHookAreFreeToSwivelAndRotate")
                        .HasColumnType("bit");

                    b.Property<bool>("AntiTwoBlockInLaceAndFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("AuxiliaryHoistControlFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("BoomAngleIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("BoomLengthIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("Cab")
                        .HasColumnType("bit");

                    b.Property<bool>("CabGlassNotCrackedAndWipersAreFunctional")
                        .HasColumnType("bit");

                    b.Property<bool>("ChargedFireExtinguisherInplace")
                        .HasColumnType("bit");

                    b.Property<bool>("CorrectCounterweightForTheLoad")
                        .HasColumnType("bit");

                    b.Property<bool>("DieselFuelLeakage")
                        .HasColumnType("bit");

                    b.Property<bool>("DrumRotationIndicatorFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("EngineFluidLevelCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("EngineHourMeter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EngineHydraulicAirElectricalOilPressureTemperatureAandFuel")
                        .HasColumnType("bit");

                    b.Property<string>("FuelLevelReading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandSignalChartVisibleToWorkers")
                        .HasColumnType("bit");

                    b.Property<bool>("HandrailsInPlaceAndNotDamaged")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicFluidLevelCorrect")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicSystemExhibitsNoApparentWeepingOrLeaks")
                        .HasColumnType("bit");

                    b.Property<bool>("LoadChartLegibleAndVisibleToOperator")
                        .HasColumnType("bit");

                    b.Property<bool>("LoadMomentIndicatorOperational")
                        .HasColumnType("bit");

                    b.Property<int>("MHCId")
                        .HasColumnType("int");

                    b.Property<bool>("MainHoistControlFunctioning")
                        .HasColumnType("bit");

                    b.Property<bool>("OperatorManualInVehicle")
                        .HasColumnType("bit");

                    b.Property<bool>("OutriggerFloatsSecuredWithPadIn")
                        .HasColumnType("bit");

                    b.Property<bool>("ReevingCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SwingBrake")
                        .HasColumnType("bit");

                    b.Property<bool>("TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder")
                        .HasColumnType("bit");

                    b.Property<bool>("TyrePressureAccetableAndTireNotDamaged")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing")
                        .HasColumnType("bit");

                    b.Property<bool>("WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MHCId");

                    b.HasIndex("UserId");

                    b.ToTable("MHCCheck");
                });

            modelBuilder.Entity("Incident.Modal.RS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RS");
                });

            modelBuilder.Entity("Incident.Modal.RSCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AC")
                        .HasColumnType("bit");

                    b.Property<bool>("Brakes")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckWindowsAreCleanAndNotDamaged")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeiselLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FireExtingisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloodLightsAreWorking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HMR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HandBreakAndWindscreenWipers")
                        .HasColumnType("bit");

                    b.Property<bool>("HornsAndAlarms")
                        .HasColumnType("bit");

                    b.Property<bool>("HydraulicControls")
                        .HasColumnType("bit");

                    b.Property<bool>("Lights")
                        .HasColumnType("bit");

                    b.Property<string>("Mirrors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NoAccidentDamageOrFrameIncludingAttachements")
                        .HasColumnType("bit");

                    b.Property<bool>("NoExcessiveFluidLeaksEspeciallyMnderMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("NoTyreDamageOrInsuficientInflation")
                        .HasColumnType("bit");

                    b.Property<bool>("NoWheelsLooseNuts")
                        .HasColumnType("bit");

                    b.Property<int>("RSId")
                        .HasColumnType("int");

                    b.Property<bool>("RadioCommunication")
                        .HasColumnType("bit");

                    b.Property<string>("SPREADEROilLeakingSPR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SeatBelts")
                        .HasColumnType("bit");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SpeedLimitOperating")
                        .HasColumnType("bit");

                    b.Property<bool>("Steering")
                        .HasColumnType("bit");

                    b.Property<string>("TailLightsAreWorking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("VMT")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RSId");

                    b.HasIndex("UserId");

                    b.ToTable("RSCheck");
                });

            modelBuilder.Entity("Incident.Modal.RTG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RTG");
                });

            modelBuilder.Entity("Incident.Modal.RTGCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DieselLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcessiveFluidLeaksEspeciallyUnderMachine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FireExtingisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloodLightsAreWorking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HMR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mirrors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoAccidentDamageOrFrameIncludingAttachements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoTyreDamageOrInsuficientInflation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoWheelsLooseNuts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RTGId")
                        .HasColumnType("int");

                    b.Property<string>("SPREADEROilLeakingFlipperDamageFlipperMissingSPR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TailLightsAreWorking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VisualCheckOfBeltsBeforeOperation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RTGId");

                    b.HasIndex("UserId");

                    b.ToTable("RTGCheck");
                });

            modelBuilder.Entity("Incident.Modal.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Incident.Modal.SnapShot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncidentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeopleInvolved")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SnapShot");
                });

            modelBuilder.Entity("Incident.Modal.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Incident.Modal.ECHCheck", b =>
                {
                    b.HasOne("Incident.Modal.ECH", "ECH")
                        .WithMany()
                        .HasForeignKey("ECHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.ForkliftCheck", b =>
                {
                    b.HasOne("Incident.Modal.Forklift", "Forklift")
                        .WithMany()
                        .HasForeignKey("ForkliftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.ITVCheck", b =>
                {
                    b.HasOne("Incident.Modal.ITV", "ITV")
                        .WithMany()
                        .HasForeignKey("ITVId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.MCCheck", b =>
                {
                    b.HasOne("Incident.Modal.MC", "MC")
                        .WithMany()
                        .HasForeignKey("MCId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.MHCCheck", b =>
                {
                    b.HasOne("Incident.Modal.MHC", "MHC")
                        .WithMany()
                        .HasForeignKey("MHCId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.RSCheck", b =>
                {
                    b.HasOne("Incident.Modal.RS", "RS")
                        .WithMany()
                        .HasForeignKey("RSId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Incident.Modal.RTGCheck", b =>
                {
                    b.HasOne("Incident.Modal.RTG", "RTG")
                        .WithMany()
                        .HasForeignKey("RTGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Incident.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
