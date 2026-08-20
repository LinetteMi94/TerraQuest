using Microsoft.AspNetCore.Mvc;

namespace TerraQuest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCountries()
    {
        return Ok("Countries endpoint works!");
    }
}