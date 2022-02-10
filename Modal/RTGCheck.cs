using System;

namespace Incident.Modal
{
    public class RTGCheck
    {
        public int Id { get; set; }
        public bool NoTyreDamageOrInsuficientInflation { get; set; }
        public bool NoWheelsLooseNuts { get; set; }
        public bool SPREADEROilLeakingFlipperDamageFlipperMissingSPR { get; set; }
        public bool NoAccidentDamageOrFrameIncludingAttachements { get; set; }
        public bool VisualCheckOfBeltsBeforeOperation { get; set; }
        public bool ExcessiveFluidLeaksEspeciallyUnderMachine { get; set; }
        public bool FloodLightsAreWorking { get; set; }
        public bool TailLightsAreWorking { get; set; }
        public bool Mirrors { get; set; }
        public bool FireExtingisher { get; set; }
        public string DieselLevel { get; set; }
        public string HMR { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public RTG RTG { get; set; }
        public int RTGId { get; set; }
        public DateTime Date { get; set; }
        public string Shift { get; set; }
    }
}