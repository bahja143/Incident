using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/itvcheck")]
    public class ITVCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ITVCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.ITVCheck.Include(i => i.ITV).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .ITVCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] ITVCheck ITVCheck)
        {
            await _context.ITVCheck.AddAsync(ITVCheck);
            await _context.SaveChangesAsync();

            return Ok(ITVCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] ITVCheck ITVCheck)
        {
            var ITVCheckDb =
                await _context.ITVCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (ITVCheckDb == null) return NotFound();

            ITVCheckDb.HydraulicControls = ITVCheck.HydraulicControls;
            ITVCheckDb.Steering = ITVCheck.Steering;
            ITVCheckDb.CheckWindowsAreCleanAndNotDamaged = ITVCheck.CheckWindowsAreCleanAndNotDamaged;
            ITVCheckDb.HandBreakAndWindscreenWipers = ITVCheck.HandBreakAndWindscreenWipers;
            ITVCheckDb.VMT = ITVCheck.VMT;
            ITVCheckDb.RadioCommunication = ITVCheck.RadioCommunication;
            ITVCheckDb.Ensure5thwheelAtCorrectHeight = ITVCheck.Ensure5thwheelAtCorrectHeight;
            ITVCheckDb.SpeedLimitOperating = ITVCheck.SpeedLimitOperating;
            ITVCheckDb.AC = ITVCheck.AC;
            ITVCheckDb.HornsAndAlarms = ITVCheck.HornsAndAlarms;
            ITVCheckDb.Lights = ITVCheck.Lights;
            ITVCheckDb.SeatBelts = ITVCheck.SeatBelts;
            ITVCheckDb.Brakes = ITVCheck.Brakes;
            ITVCheckDb.NoAccidentDamageOrFrameIncludingAttachements = ITVCheck.NoAccidentDamageOrFrameIncludingAttachements;
            ITVCheckDb.NoTyreDamageOrInsuficientInflation = ITVCheck.NoTyreDamageOrInsuficientInflation;
            ITVCheckDb.NoWheelsLooseNuts = ITVCheck.NoWheelsLooseNuts;
            ITVCheckDb.NoExcessiveFluidLeaksEspeciallyMnderMachine = ITVCheck.NoExcessiveFluidLeaksEspeciallyMnderMachine;
            ITVCheckDb.FloodLightsAreWorking = ITVCheck.FloodLightsAreWorking;
            ITVCheckDb.TailLightsAreWorking = ITVCheck.TailLightsAreWorking;
            ITVCheckDb.Mirrors = ITVCheck.Mirrors;
            ITVCheckDb.TurntableLockingBarInFullyLatchedPosition = ITVCheck.TurntableLockingBarInFullyLatchedPosition;
            ITVCheckDb.TrailerLegsLiftedToFullHeight = ITVCheck.TrailerLegsLiftedToFullHeight;
            ITVCheckDb.TrailerSuzieHosesAndCableSecure = ITVCheck.TrailerSuzieHosesAndCableSecure;
            ITVCheckDb.FireExtingisher = ITVCheck.FireExtingisher;
            ITVCheckDb.DeiselLevel = ITVCheck.DeiselLevel;
            ITVCheckDb.HMR = ITVCheck.HMR;
            ITVCheckDb.Shift = ITVCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(ITVCheckDb);
        }
    }
}