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
    string interestingFact)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string Capital { get; set; } = capital;
    public Region Region { get; private set; } = region; //часть света
    public string FlagPath { get; private set; } = flagPath;
    public long Population { get; set; } = population;
    public double Area { get; set; } = area; //площадь
    public string Currency { get; set; } = currency; //валюта
    public List<CountryLanguage> CountryLanguages { get; private set; } = [];
    public string InterestingFact { get; set; } = interestingFact;
}