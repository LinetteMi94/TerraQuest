namespace TerraQuest.Models.JsonModels;

public class CountryJson
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public Region Region { get; set; }
    public string FlagPath { get; set; }
    public long Population { get; set; }
    public double Area { get; set; }
    public string Currency { get; set; }
    public List<LanguageJson> Languages { get; set; } = new();
    public string InterestingFact { get; set; }
}