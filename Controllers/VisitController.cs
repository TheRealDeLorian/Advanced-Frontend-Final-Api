using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Advanced_Frontend_Final_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Frontend_Final_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase
    {
        private readonly IDbContextFactory<TestDbContext> _contextFactory;

        public VisitController(IDbContextFactory<TestDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<Visit>>> GetVisitsByUserId(int userId)
        {
            try
            {
                await using var context = _contextFactory.CreateDbContext();
                var visits = await context.Visits.Where(v => v.Personid == userId).ToListAsync();
                return Ok(visits);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Visit>> AddNewVisit([FromBody] VisitDTO visitDto)
        {
            Console.WriteLine("visit post reached");

            if (visitDto == null)
            {
                return BadRequest("Visit is null");
            }

            try
            {
                await using var context = _contextFactory.CreateDbContext();
                var visit = new Visit
                {
                    Personid = visitDto.Personid,
                    Templeid = visitDto.Templeid,
                    Visittime = visitDto.VisitTime,
                    Note = visitDto.Note
                };
                context.Visits.Add(visit); // The database will assign an id here
                await context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetVisitsByUserId), new { userId = visit.Personid }, visit);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}