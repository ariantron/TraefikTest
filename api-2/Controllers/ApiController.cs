using Microsoft.AspNetCore.Mvc;

namespace api_2.Controllers;

[ApiController]
[Route("/")]
public class HelloController : ControllerBase
{
    [HttpGet]
	public IActionResult Get()
	{
		return Ok("API 2");
	}
}
