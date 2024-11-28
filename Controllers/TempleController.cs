using Advanced_Frontend_Final_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Frontend_Final_Api.Controllers;


public class TempleController : ControllerBase
{
  private readonly IDbContextFactory<TestDbContext> _context;

  public TempleController(IDbContextFactory<TestDbContext> context)
  {
    _context = context;
  }

  [HttpGet("/api/temples")]
  public async Task<ActionResult<IEnumerable<Temple>>> GetAllTemplesAsync()
  {
    var temples = new List<Temple>();
    var context = _context.CreateDbContext();

    try
    {
      temples = await context.Temples.ToListAsync();
      return Ok(temples);
    }
    catch (Exception ex)
    {
      return temples;
    }
  }
}