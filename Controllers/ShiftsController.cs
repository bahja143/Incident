using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/shifts")]
    public class ShiftsController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ShiftsController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.Shifts.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .Shifts
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] Shift Shift)
        {
            await _context.Shifts.AddAsync(Shift);
            await _context.SaveChangesAsync();

            return Ok(Shift);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] Shift Shift)
        {
            var ShiftDb =
                await _context.Shifts.SingleOrDefaultAsync(c => c.Id == Id);

            if (ShiftDb == null) return NotFound();

            ShiftDb.Time = Shift.Time;

            await _context.SaveChangesAsync();

            return Ok(ShiftDb);
        }
    }
}