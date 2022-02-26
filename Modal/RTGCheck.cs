using System;

namespace Incident.Modal
{
    public class RTGCheck
    {
        public int Id { get; set; }
        public bool HydraulicControls { get; set; }
        public bool Steering { get; set; }
        public bool WindowsAreCleanAndNotDamaged { get; set; }
        public bool HandbreakAndwindScreenWipers { get; set; }
        public bool VMT { get; set; }
        public bool RadioCommunication { get; set; }
        public bool Lights { get; set; }
        public bool SpeedLimitOperating { get; set; }
        public bool AC { get; set; }
        public bool HornsAlarms { get; set; }
        public bool SeatBelts { get; set; }
        public bool Brakes { get; set; }
        public bool NoTyreDamageOrInsuficientInflation { get; set; }
        public bool NoWheelsLooseNuts { get; set; }
        public bool NoAccidentDamageOrFrameIncludingAttachements { get; set; }
        public bool SPREADEROilLeakingSPR { get; set; }
        public bool NoExcessiveFluidLeaksEspeciallyUnderMachine { get; set; }
        public bool FloodLightsAreWorking { get; set; }
        public bool TailLightsAreWorking { get; set; }
        public bool Mirrors { get; set; }
        public bool FireExtingisher { get; set; }
        public string DeiselLevel { get; set; }
        public string HMR { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public RTG RTG { get; set; }
        public int RTGId { get; set; }
        public DateTime Date { get; set; }
        public string Shift { get; set; }
    }
}