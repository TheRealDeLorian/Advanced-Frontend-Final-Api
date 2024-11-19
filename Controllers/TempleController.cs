using Final_Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Api.Controllers;

public class TempleController : ControllerBase
{
  private readonly IDbContextFactory<AppDbContext> _context;

  public TempleController(IDbContextFactory<AppDbContext> context)
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