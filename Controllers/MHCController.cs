using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/mhc")]
    public class MHCController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public MHCController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.MHC.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .MHC
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] MHC MHC)
        {
            await _context.MHC.AddAsync(MHC);
            await _context.SaveChangesAsync();

            return Ok(MHC);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] MHC MHC)
        {
            var MHCDb =
                await _context.MHC.SingleOrDefaultAsync(c => c.Id == Id);

            if (MHCDb == null) return NotFound();

            MHCDb.Name = MHC.Name;
            MHCDb.Description = MHC.Description;

            await _context.SaveChangesAsync();

            return Ok(MHCDb);
        }
    }
}