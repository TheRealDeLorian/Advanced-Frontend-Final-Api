using Microsoft.AspNetCore.Mvc;
using Advanced_Frontend_Final_Api.Models;

[ApiController]
[Route("api/[controller]")]
public class VisitsController : ControllerBase
{
    [HttpPost]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        if (visit == null)
        {
            return BadRequest("Visit data is required.");
        }

        return Ok(new
        {
            Message = "Visit added successfully!",
            Visit = visit
        });
    }
}
