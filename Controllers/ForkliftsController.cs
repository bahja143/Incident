using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/forklift")]
    public class ForklistController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ForklistController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.Forklift.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .Forklift
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] Forklift forklift)
        {
            await _context.Forklift.AddAsync(forklift);
            await _context.SaveChangesAsync();

            return Ok(forklift);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] Forklift forklift)
        {
            var forkliftDb =
                await _context.Forklift.SingleOrDefaultAsync(c => c.Id == Id);

            if (forkliftDb == null) return NotFound();

            forkliftDb.Name = forklift.Name;
            forkliftDb.Description = forklift.Description;

            await _context.SaveChangesAsync();

            return Ok(forkliftDb);
        }
    }
}