using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/rtg")]
    public class RTGController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public RTGController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.RTG.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .RTG
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] RTG RTG)
        {
            await _context.RTG.AddAsync(RTG);
            await _context.SaveChangesAsync();

            return Ok(RTG);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] RTG RTG)
        {
            var RTGDb =
                await _context.RTG.SingleOrDefaultAsync(c => c.Id == Id);

            if (RTGDb == null) return NotFound();

            RTGDb.Name = RTG.Name;
            RTGDb.Description = RTG.Description;

            await _context.SaveChangesAsync();

            return Ok(RTGDb);
        }
    }
}