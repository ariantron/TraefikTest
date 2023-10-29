using Microsoft.AspNetCore.Mvc;

namespace api_1.Controllers;

[ApiController]
[Route("/")]
public class ApiController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		return Ok("API 1");
	}
}
