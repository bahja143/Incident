namespace Incident.Modal
{
    public class MCCheck
    {
        public int Id { get; set; }
        public bool EngineFluidLevelCorrect { get; set; }
        public bool HydraulicFluidLevelCorrect { get; set; }
        public bool HydraulicSystemExhibitsNoApparentWeepingOrLeaks { get; set; }
        public bool AirSystemexhibitsNoAudibleLeaks { get; set; }
        public bool TyrePressureAccetableAndTireNotDamaged { get; set; }
        public bool TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder { get; set; }
        public bool WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl { get; set; }
        public bool ReevingCorrect { get; set; }
        public bool WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing { get; set; }
        public bool AllAndHookAreFreeToSwivelAndRotate { get; set; }
        public bool OutriggerFloatsSecuredWithPadIn { get; set; }
        public bool Cab { get; set; }
        public bool HandrailsInPlaceAndNotDamaged { get; set; }
        public bool OperatorManualInVehicle { get; set; }
        public bool LoadChartLegibleAndVisibleToOperator { get; set; }
        public bool HandSignalChartVisibleToWorkers { get; set; }
        public bool ChargedFireExtinguisherInplace { get; set; }
        public bool CabGlassNotCrackedAndWipersAreFunctional { get; set; }
        public bool LoadMomentIndicatorOperational { get; set; }
        public bool DrumRotationIndicatorFunctioning { get; set; }
        public bool BoomLengthIndicatorFunctioning { get; set; }
        public bool BoomAngleIndicatorFunctioning { get; set; }
        public bool EngineHydraulicAirElectricalOilPressureTemperatureAandFuel { get; set; }
        public bool CorrectCounterweightForTheLoad { get; set; }
        public bool MainHoistControlFunctioning { get; set; }
        public bool AntiTwoBlockInLaceAndFunctioning { get; set; }
        public bool SwingBrake { get; set; }
        public bool AuxiliaryHoistControlFunctioning { get; set; }
        public bool DieselFuelLeakage { get; set; }
        public string EngineHourMeter { get; set; }
        public string FuelLevelReading { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public MC MC { get; set; }
        public int MCId { get; set; }
        public string Shift { get; set; }
    }
}