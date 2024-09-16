using Microsoft.AspNetCore.Mvc;

namespace HangfireBackgroundJob.Controller;
[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}