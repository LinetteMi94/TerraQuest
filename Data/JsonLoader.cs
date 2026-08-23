using TerraQuest.Models.JsonModels;
using System.Text.Json;

namespace TerraQuest.Data;

public class JsonLoader
{
    
    public static List<CountryJson> LoadCountries()
    {
        var options = new JsonSerializerOptions 
        {
            PropertyNameCaseInsensitive = true
        };
        string json = File.ReadAllText("DataFiles/Countries.json");
        List<CountryJson>? countries = JsonSerializer.Deserialize<List<CountryJson>>(json, options);
        return countries ?? new List<CountryJson>();
    }
}