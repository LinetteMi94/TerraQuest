namespace TerraQuest.Models;

public class CountryLanguage
{
    public int Id { get; internal set; }
    
    public int CountryId { get; internal set; }
    public Country Country { get; internal set; }
    
    public int LanguageId { get; internal set; }
    public Language Language { get; internal set; }
    
    public int? SinceYear { get; internal set; }
    public bool IsOfficial { get; internal set; }
}