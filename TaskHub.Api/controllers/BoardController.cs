
using Microsoft.AspNetCore.Mvc;

namespace TaskHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoardController : ControllerBase
{
    [HttpGet("all")]
    public IActionResult GetAll()
    {
        return Ok(new[] { new { id = Guid.NewGuid() }, new { id = Guid.NewGuid() } });
    }

    [HttpGet("{id:guid}")]
    public IActionResult Get(Guid id)
    {
        return Ok(new { id });
    }
}