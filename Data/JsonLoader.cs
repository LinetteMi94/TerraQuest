using TerraQuest.Models.JsonModels;
using System.Text.Json;

namespace TerraQuest.Data;

public static class JsonLoader
{
    
    public static List<CountryJson> LoadCountries()
    {
        var options = new JsonSerializerOptions 
        {
            PropertyNameCaseInsensitive = true
        };
        var json = File.ReadAllText("DataFiles/Countries.json");
        var countries = JsonSerializer.Deserialize<List<CountryJson>>(json, options);
        return countries ?? [];
    }
}