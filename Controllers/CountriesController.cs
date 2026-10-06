using Microsoft.AspNetCore.Mvc;
using TerraQuest.Data;

namespace TerraQuest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly TerraQuestContext _context;

    public CountriesController(TerraQuestContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetCountries()
    {
        var countries = _context.Countries.ToList();
        return Ok(countries);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetCountry(int id)
    {
        var country = _context.Countries.FirstOrDefault(x => x.Id == id);
        if (country == null)
        {
            return NotFound();
        }
        return Ok(country);
    }
    
    [HttpGet("search")]
    public IActionResult SearchCountries(string name)
    {
        var country = _context.Countries.FirstOrDefault(x => x.Name == name);
        if (country == null)
        {
            return NotFound();
        }
        return Ok(country);
    }
}