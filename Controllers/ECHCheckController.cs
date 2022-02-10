using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/echcheck")]
    public class ECHCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ECHCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.ECHCheck.Include(e => e.ECH).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .ECHCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] ECHCheck ECHCheck)
        {
            await _context.ECHCheck.AddAsync(ECHCheck);
            await _context.SaveChangesAsync();

            return Ok(ECHCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] ECHCheck ECHCheck)
        {
            var MHCCheckDb =
                await _context.ECHCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (MHCCheckDb == null) return NotFound();

            MHCCheckDb.HydraulicControls = ECHCheck.HydraulicControls;
            MHCCheckDb.Steering = ECHCheck.Steering;
            MHCCheckDb.CheckWindowsAreCleanAndNotDamaged = ECHCheck.CheckWindowsAreCleanAndNotDamaged;
            MHCCheckDb.HandBreakAndWindscreenWipers = ECHCheck.HandBreakAndWindscreenWipers;
            MHCCheckDb.VMT = ECHCheck.VMT;
            MHCCheckDb.RadioCommunication = ECHCheck.RadioCommunication;
            MHCCheckDb.Lights = ECHCheck.Lights;
            MHCCheckDb.SpeedLimitOperating = ECHCheck.SpeedLimitOperating;
            MHCCheckDb.AC = ECHCheck.AC;
            MHCCheckDb.HornsAndAlarms = ECHCheck.HornsAndAlarms;
            MHCCheckDb.SeatBelts = ECHCheck.SeatBelts;
            MHCCheckDb.Brakes = ECHCheck.Brakes;
            MHCCheckDb.NoTyreDamageOrInsuficientInflation = ECHCheck.NoTyreDamageOrInsuficientInflation;
            MHCCheckDb.NoWheelsLooseNuts = ECHCheck.NoWheelsLooseNuts;
            MHCCheckDb.NoAccidentDamageOrFrameIncludingAttachements = ECHCheck.NoAccidentDamageOrFrameIncludingAttachements;
            MHCCheckDb.NoExcessiveFluidLeaksEspeciallyMnderMachine = ECHCheck.NoExcessiveFluidLeaksEspeciallyMnderMachine;
            MHCCheckDb.SPREADEROilLeakingSPR = ECHCheck.SPREADEROilLeakingSPR;
            MHCCheckDb.FloodLightsAreWorking = ECHCheck.FloodLightsAreWorking;
            MHCCheckDb.TailLightsAreWorking = ECHCheck.TailLightsAreWorking;
            MHCCheckDb.Mirrors = ECHCheck.Mirrors;
            MHCCheckDb.FireExtingisher = ECHCheck.FireExtingisher;
            MHCCheckDb.DeiselLevel = ECHCheck.DeiselLevel;
            MHCCheckDb.HMR = ECHCheck.HMR;
            MHCCheckDb.Shift = ECHCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(MHCCheckDb);
        }
    }
}