using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/rscheck")]
    public class RSCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public RSCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.RSCheck.Include(r => r.RS).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .RSCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] RSCheck RSCheck)
        {
            await _context.RSCheck.AddAsync(RSCheck);
            await _context.SaveChangesAsync();

            return Ok(RSCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] RSCheck RSCheck)
        {
            var MHCCheckDb =
                await _context.RSCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (MHCCheckDb == null) return NotFound();

            MHCCheckDb.HydraulicControls = RSCheck.HydraulicControls;
            MHCCheckDb.Steering = RSCheck.Steering;
            MHCCheckDb.CheckWindowsAreCleanAndNotDamaged = RSCheck.CheckWindowsAreCleanAndNotDamaged;
            MHCCheckDb.HandBreakAndWindscreenWipers = RSCheck.HandBreakAndWindscreenWipers;
            MHCCheckDb.VMT = RSCheck.VMT;
            MHCCheckDb.RadioCommunication = RSCheck.RadioCommunication;
            MHCCheckDb.Lights = RSCheck.Lights;
            MHCCheckDb.SpeedLimitOperating = RSCheck.SpeedLimitOperating;
            MHCCheckDb.AC = RSCheck.AC;
            MHCCheckDb.HornsAndAlarms = RSCheck.HornsAndAlarms;
            MHCCheckDb.SeatBelts = RSCheck.SeatBelts;
            MHCCheckDb.Brakes = RSCheck.Brakes;
            MHCCheckDb.NoTyreDamageOrInsuficientInflation = RSCheck.NoTyreDamageOrInsuficientInflation;
            MHCCheckDb.NoWheelsLooseNuts = RSCheck.NoWheelsLooseNuts;
            MHCCheckDb.NoAccidentDamageOrFrameIncludingAttachements = RSCheck.NoAccidentDamageOrFrameIncludingAttachements;
            MHCCheckDb.NoExcessiveFluidLeaksEspeciallyMnderMachine = RSCheck.NoExcessiveFluidLeaksEspeciallyMnderMachine;
            MHCCheckDb.SPREADEROilLeakingSPR = RSCheck.SPREADEROilLeakingSPR;
            MHCCheckDb.FloodLightsAreWorking = RSCheck.FloodLightsAreWorking;
            MHCCheckDb.TailLightsAreWorking = RSCheck.TailLightsAreWorking;
            MHCCheckDb.Mirrors = RSCheck.Mirrors;
            MHCCheckDb.FireExtingisher = RSCheck.FireExtingisher;
            MHCCheckDb.DeiselLevel = RSCheck.DeiselLevel;
            MHCCheckDb.HMR = RSCheck.HMR;
            MHCCheckDb.Shift = RSCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(MHCCheckDb);
        }
    }
}