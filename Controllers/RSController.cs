using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/rs")]
    public class RSController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public RSController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.RS.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .RS
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] RS RS)
        {
            await _context.RS.AddAsync(RS);
            await _context.SaveChangesAsync();

            return Ok(RS);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] RS RS)
        {
            var RSDb =
                await _context.RS.SingleOrDefaultAsync(c => c.Id == Id);

            if (RSDb == null) return NotFound();

            RSDb.Name = RS.Name;
            RSDb.Description = RS.Description;

            await _context.SaveChangesAsync();

            return Ok(RSDb);
        }
    }
}