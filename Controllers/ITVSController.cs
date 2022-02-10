using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/itv")]
    public class ITVSController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ITVSController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.ITV.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .ITV
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] ITV ITV)
        {
            await _context.ITV.AddAsync(ITV);
            await _context.SaveChangesAsync();

            return Ok(ITV);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] ITV ITV)
        {
            var ITVDb =
                await _context.ITV.SingleOrDefaultAsync(c => c.Id == Id);

            if (ITVDb == null) return NotFound();

            ITVDb.Name = ITV.Name;
            ITVDb.Description = ITV.Description;

            await _context.SaveChangesAsync();

            return Ok(ITVDb);
        }
    }
}