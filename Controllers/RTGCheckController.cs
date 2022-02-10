using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/rtgcheck")]
    public class RTGCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public RTGCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.RTGCheck.Include(r => r.RTG).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .RTGCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] RTGCheck RTGCheck)
        {
            await _context.RTGCheck.AddAsync(RTGCheck);
            await _context.SaveChangesAsync();

            return Ok(RTGCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] RTGCheck RTGCheck)
        {
            var RTGCheckDb =
                await _context.RTGCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (RTGCheckDb == null) return NotFound();

            RTGCheckDb.NoTyreDamageOrInsuficientInflation = RTGCheck.NoTyreDamageOrInsuficientInflation;
            RTGCheckDb.NoWheelsLooseNuts = RTGCheck.NoWheelsLooseNuts;
            RTGCheckDb.SPREADEROilLeakingFlipperDamageFlipperMissingSPR = RTGCheck.SPREADEROilLeakingFlipperDamageFlipperMissingSPR;
            RTGCheckDb.NoAccidentDamageOrFrameIncludingAttachements = RTGCheck.NoAccidentDamageOrFrameIncludingAttachements;
            RTGCheckDb.VisualCheckOfBeltsBeforeOperation = RTGCheck.VisualCheckOfBeltsBeforeOperation;
            RTGCheckDb.ExcessiveFluidLeaksEspeciallyUnderMachine = RTGCheck.ExcessiveFluidLeaksEspeciallyUnderMachine;
            RTGCheckDb.FloodLightsAreWorking = RTGCheck.FloodLightsAreWorking;
            RTGCheckDb.TailLightsAreWorking = RTGCheck.TailLightsAreWorking;
            RTGCheckDb.Mirrors = RTGCheck.Mirrors;
            RTGCheckDb.FireExtingisher = RTGCheck.FireExtingisher;
            RTGCheckDb.DieselLevel = RTGCheck.DieselLevel;
            RTGCheckDb.HMR = RTGCheck.HMR;
            RTGCheckDb.Shift = RTGCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(RTGCheckDb);
        }
    }
}