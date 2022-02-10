using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/SnapShot")]
    public class SnapshotController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public SnapshotController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.SnapShot.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .SnapShot
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] SnapShot SnapShot)
        {
            await _context.SnapShot.AddAsync(SnapShot);
            await _context.SaveChangesAsync();

            return Ok(SnapShot);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] SnapShot SnapShot)
        {
            var SnapShotDb =
                await _context.SnapShot.SingleOrDefaultAsync(c => c.Id == Id);

            if (SnapShotDb == null) return NotFound();

            SnapShotDb.Category = SnapShot.Category;
            SnapShotDb.IncidentType = SnapShot.IncidentType;
            SnapShotDb.Location = SnapShot.Location;
            SnapShotDb.Shift = SnapShot.Shift;
            SnapShotDb.PeopleInvolved = SnapShot.PeopleInvolved;
            SnapShotDb.Equipment = SnapShot.Equipment;
            SnapShotDb.Responsible = SnapShot.Responsible;
            SnapShotDb.Image = SnapShot.Image;
            SnapShotDb.Status = SnapShot.Status;
            SnapShotDb.Shift = SnapShot.Shift;

            await _context.SaveChangesAsync();

            return Ok(SnapShotDb);
        }
    }
}