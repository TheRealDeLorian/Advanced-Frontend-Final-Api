using Advanced_Frontend_Final_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Frontend_Final_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
  private readonly IDbContextFactory<TestDbContext> _context;

  public PersonController(IDbContextFactory<TestDbContext> context)
  {
    _context = context;
  }

   [HttpGet]
  public async Task<ActionResult<IEnumerable<Person>>> GetAllPeopleAsync()
  {
    var people = new List<Person>();
    var context = _context.CreateDbContext();

    try
    {
      people = await context.People.ToListAsync();
      return Ok(people);
    }
    catch (Exception ex)
    {
      return people;
    }
  }

  [HttpGet("{email}")]
  public async Task<ActionResult<int>> GetPersonIdByEmailAsync(string email)
  {
    var context = _context.CreateDbContext();

    try
    {
      var person = await context.People.FirstOrDefaultAsync(p => p.Email == email);
      if (person == null)
      {
        return NotFound();
      }
      return person.Id;
    }
    catch (Exception ex)
    {
      return StatusCode(500, "Internal server error");
    }
  }
}