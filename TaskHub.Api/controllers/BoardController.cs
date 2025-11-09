
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BoardController : ControllerBase
{
    [HttpGet("/boards/")]
    public IActionResult Hello()
    {
        return Ok("Hello from BoardController!");
    }
}