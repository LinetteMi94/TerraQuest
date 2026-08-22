using TerraQuest.Models;

namespace TerraQuest.Data;

public class CountrySeed
{
    private List<Country> Countries { get; set; } = [];
    private List<Language> Languages { get; set; } = [];
    private int _lastCountryId;
    private int _lastLanguageId;
    private int _lastCountryLanguageId;
    
    public void SeedCountries()
    {
        Country spain = new Country(++_lastCountryId, "Испания", "Мадрид",
            "Images/Flags/spain.png", "Евро", 48000000,
            505990.37, Region.Europe,
            "Испания занимает большую часть Пиренейского полуострова и имеет сухопутную границу" +
            " только с четырьмя странами: Португалией, Францией, Андоррой и Марокко (через территории Сеута и Мелилья).");
        Countries.Add(spain);
        Language spanish = GetOrCreateLanguage("Испанский");
        CountryLanguage spainSpanish = new CountryLanguage
        {
            Country =  spain,
            Language = spanish,
            IsOfficial = true,
            CountryId = spain.Id,
            LanguageId = spanish.Id,
            Id = ++_lastCountryLanguageId
        };
        spain.CountryLanguages.Add(spainSpanish);
        
        
        
        
        
        Country canada = new Country(++_lastCountryId, "Канада", "Оттава",
            "Images/Flags/canada.png", "Канадский доллар", 41000000,
            9984670, Region.NorthAmerica,
            "Канада имеет самую длинную береговую линию в мире " +
            "и занимает второе место по площади среди стран мира");
        Countries.Add(canada);
        Country peru = new Country(++_lastCountryId, "Перу", "Лима",
            "Images/Flags/peru.png", "Перуанский соль", 34000000,
            1285216, Region.SouthAmerica,
            "В Перу находится древний город Мачу-Пикчу, " +
            "построенный цивилизацией инков высоко в Андах.");
        Countries.Add(peru);
    }

    public IReadOnlyList<Country> GetCountries() => Countries;

    private Language GetOrCreateLanguage(string languageName)
    {
        Language? language = Languages.FirstOrDefault(lang => lang.Name == languageName);
        if (language == null) 
        {
            language = new Language(languageName);
            language.Id = ++_lastLanguageId;
            Languages.Add(language);
        }
        return language;
    }
}