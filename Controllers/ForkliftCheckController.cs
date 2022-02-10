using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/forkliftcheck")]
    public class ForkliftCheckCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ForkliftCheckCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.ForkliftCheck.Include(f => f.Forklift).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .ForkliftCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] ForkliftCheck ForkliftCheck)
        {
            await _context.ForkliftCheck.AddAsync(ForkliftCheck);
            await _context.SaveChangesAsync();

            return Ok(ForkliftCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] ForkliftCheck ForkliftCheck)
        {
            var ForkliftCheckDb =
                await _context.ForkliftCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (ForkliftCheckDb == null) return NotFound();

            ForkliftCheckDb.HydraulicControls = ForkliftCheck.HydraulicControls;
            ForkliftCheckDb.Steering = ForkliftCheck.Steering;
            ForkliftCheckDb.HandBreak = ForkliftCheck.HandBreak;
            ForkliftCheckDb.Lights = ForkliftCheck.Lights;
            ForkliftCheckDb.HornsAndAlarms = ForkliftCheck.HornsAndAlarms;
            ForkliftCheckDb.SeatBelts = ForkliftCheck.SeatBelts;
            ForkliftCheckDb.Brakes = ForkliftCheck.Brakes;
            ForkliftCheckDb.NoAccidentDamageOrFrameIncludingAttachements = ForkliftCheck.NoAccidentDamageOrFrameIncludingAttachements;
            ForkliftCheckDb.NoExcessiveFluidLeaksEspeciallyUnderMachine = ForkliftCheck.NoExcessiveFluidLeaksEspeciallyUnderMachine;
            ForkliftCheckDb.NoTyreDamageOrInsuficientInflation = ForkliftCheck.NoTyreDamageOrInsuficientInflation;
            ForkliftCheckDb.NoWheelsLooseNuts = ForkliftCheck.NoWheelsLooseNuts;
            ForkliftCheckDb.FloodLightsAreWorking = ForkliftCheck.FloodLightsAreWorking;
            ForkliftCheckDb.Forklift = ForkliftCheck.Forklift;
            ForkliftCheckDb.TailLightsAreWorking = ForkliftCheck.TailLightsAreWorking;
            ForkliftCheckDb.Mirrors = ForkliftCheck.Mirrors;
            ForkliftCheckDb.RotatingAmbersLightsAreWorking = ForkliftCheck.RotatingAmbersLightsAreWorking;
            ForkliftCheckDb.FireExtingisher = ForkliftCheck.FireExtingisher;
            ForkliftCheckDb.DeiselLevel = ForkliftCheck.DeiselLevel;
            ForkliftCheckDb.HMR = ForkliftCheck.HMR;
            ForkliftCheckDb.Shift = ForkliftCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(ForkliftCheckDb);
        }
    }
}