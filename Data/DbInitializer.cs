using System.Data;
using TerraQuest.Models.JsonModels;
using TerraQuest.Models;
using System.Text.Json;

namespace TerraQuest.Data;

public class DbInitializer
{
    private int _lastCountryId;
    private int _lastLanguageId;
    
    public void Initialize(TerraQuestContext context)
    {
        if (!context.Countries.Any())
        {
            SeedData(context, JsonLoader.LoadCountries());
            context.SaveChanges();
        }
    }

    private void SeedData(TerraQuestContext context, List<CountryJson> countriesJson)
    {
        foreach (var countryJson in countriesJson)
        {
            var country = new Country(++_lastCountryId, countryJson.Name,  countryJson.Capital, 
                countryJson.FlagPath, countryJson.Currency, countryJson.Population, countryJson.Area,
                countryJson.Region,countryJson.InterestingFact);
            context.Countries.Add(country);
            foreach (var languageJson in countryJson.Languages)
            {
                var language = GetOrCreateLanguage(context, languageJson.Name);
                var countryLanguage = new CountryLanguage
                {
                    Country = country,
                    Language = language,
                    SinceYear = languageJson.SinceYear,
                    IsOfficial = languageJson.IsOfficial
                };
                context.CountryLanguages.Add(countryLanguage);
            }
        }
    }
    
    private Language GetOrCreateLanguage(TerraQuestContext context, string languageName)
    {
        Language? language = context.Languages.Local.FirstOrDefault(lang => lang.Name == languageName);
        if (language == null) 
        {
            language = new Language(languageName);
            language.Id = ++_lastLanguageId;
            context.Languages.Add(language);
        }
        return language;
    }
}