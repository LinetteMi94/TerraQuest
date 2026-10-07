using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using TerraQuest.Data;
using TerraQuest.Models;

namespace TerraQuest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController(TerraQuestContext context) : ControllerBase
{
    [HttpGet]
    public IActionResult GetCountries()
    {
        var countries = context.Countries.ToList();
        return Ok(countries);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetCountry(int id)
    {
        var country = context.Countries.FirstOrDefault(x => x.Id == id);
        if (country == null)
        {
            return NotFound();
        }
        return Ok(country);
    }
    
    [HttpGet("region/{region}")]
    public IActionResult GetCountryByRegion(string region)
    {
        if (!TryParseRegion(region, out Region userRegion)) return NotFound();
        var countries = context.Countries.Where(x => x.Region == userRegion).ToList();
        if (!countries.Any()) return NotFound();
        return Ok(countries);
    }
    
    [HttpGet("search")]
    public IActionResult SearchCountries(string name)
    {
        var countries = context.Countries.AsEnumerable().Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        if (!countries.Any())
        {
            return NotFound();
        }
        return Ok(countries);
    }

    private bool TryParseRegion(string region, out Region result)
    {
        foreach (Region item in Enum.GetValues<Region>())
        {
            var field = typeof(Region).GetField(item.ToString());
            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();

            if (attribute?.Description.Equals(region, StringComparison.OrdinalIgnoreCase) != true) continue;
            result = item;
            return true;
        }
        result = default;
        return false;
    }
}