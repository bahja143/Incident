using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/ech")]
    public class ECHController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public ECHController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.ECH.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .ECH
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] ECH ECH)
        {
            await _context.ECH.AddAsync(ECH);
            await _context.SaveChangesAsync();

            return Ok(ECH);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] ECH ECH)
        {
            var ECHDb =
                await _context.ECH.SingleOrDefaultAsync(c => c.Id == Id);

            if (ECHDb == null) return NotFound();

            ECHDb.Name = ECH.Name;
            ECHDb.Description = ECH.Description;

            await _context.SaveChangesAsync();

            return Ok(ECHDb);
        }
    }
}