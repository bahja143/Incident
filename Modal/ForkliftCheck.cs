using System;
using System.ComponentModel.DataAnnotations;

namespace Incident.Modal
{
    public class ForkliftCheck
    {
        public int Id { get; set; }
        public bool HydraulicControls { get; set; }
        public bool Steering { get; set; }
        public bool HandBreak { get; set; }
        public bool Lights { get; set; }
        public bool HornsAndAlarms { get; set; }
        public bool SeatBelts { get; set; }
        public bool Brakes { get; set; }
        public bool NoTyreDamageOrInsuficientInflation { get; set; }
        public bool NoWheelsLooseNuts { get; set; }
        public bool NoAccidentDamageOrFrameIncludingAttachements { get; set; }
        public bool NoExcessiveFluidLeaksEspeciallyUnderMachine { get; set; }
        public bool FloodLightsAreWorking { get; set; }
        public bool TailLightsAreWorking { get; set; }
        public bool Mirrors { get; set; }
        public bool RotatingAmbersLightsAreWorking { get; set; }
        public bool FireExtingisher { get; set; }
        public string DeiselLevel { get; set; }
        public string HMR { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Forklift Forklift { get; set; }
        public int ForkliftId { get; set; }
        public DateTime date { get; set; }
        public string Shift { get; set; }

    }
}