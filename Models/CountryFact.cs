namespace TerraQuest.Models;

public class CountryFact
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; internal set; }
}