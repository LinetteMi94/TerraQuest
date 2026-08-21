namespace TerraQuest.Models;

public class Country(
    int id,
    string name,
    string capital,
    string flagPath,
    string currency,
    long population,
    double area,
    Region region,
    string interestingFact,
    IReadOnlyList<string> languages)
{
    public int Id { get; } = id;
    public string Name { get; private set; } = name;
    public string Capital { get; set; } = capital;
    public Region Region { get; private set; } = region; //часть света
    public string FlagPath { get; private set; } = flagPath;
    public long Population { get; set; } = population;
    public double Area { get; set; } = area; //площадь
    public string Currency { get; set; } = currency; //валюта
    public IReadOnlyList<string> Languages { get; private set; } = languages;
    public string InterestingFact { get; set; } = interestingFact;
}