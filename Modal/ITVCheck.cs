using System;

namespace Incident.Modal
{
    public class ITVCheck
    {
        public int Id { get; set; }
        public bool HydraulicControls { get; set; }
        public bool Steering { get; set; }
        public bool CheckWindowsAreCleanAndNotDamaged { get; set; }
        public bool HandBreakAndWindscreenWipers { get; set; }
        public bool VMT { get; set; }
        public bool RadioCommunication { get; set; }
        public bool Ensure5thwheelAtCorrectHeight { get; set; }
        public bool Lights { get; set; }
        public bool SpeedLimitOperating { get; set; }
        public bool AC { get; set; }
        public bool HornsAndAlarms { get; set; }
        public bool SeatBelts { get; set; }
        public bool Brakes { get; set; }
        public bool NoTyreDamageOrInsuficientInflation { get; set; }
        public bool NoWheelsLooseNuts { get; set; }
        public bool NoAccidentDamageOrFrameIncludingAttachements { get; set; }
        public bool NoExcessiveFluidLeaksEspeciallyMnderMachine { get; set; }
        public bool FloodLightsAreWorking { get; set; }
        public bool TailLightsAreWorking { get; set; }
        public bool Mirrors { get; set; }
        public bool TurntableLockingBarInFullyLatchedPosition { get; set; }
        public bool TrailerSuzieHosesAndCableSecure { get; set; }
        public bool TrailerLegsLiftedToFullHeight { get; set; }
        public bool FireExtingisher { get; set; }
        public string DeiselLevel { get; set; }
        public string HMR { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ITV ITV { get; set; }
        public int ITVId { get; set; }
        public DateTime date { get; set; }
        public string Shift { get; set; }
    }
}