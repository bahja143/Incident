using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/MC")]
    public class MCController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public MCController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.MC.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .MC
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] MC MC)
        {
            await _context.MC.AddAsync(MC);
            await _context.SaveChangesAsync();

            return Ok(MC);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] MC MC)
        {
            var MCDb =
                await _context.MC.SingleOrDefaultAsync(c => c.Id == Id);

            if (MCDb == null) return NotFound();

            MCDb.Name = MC.Name;
            MCDb.Description = MC.Description;

            await _context.SaveChangesAsync();

            return Ok(MCDb);
        }
    }
}