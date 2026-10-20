using Microsoft.EntityFrameworkCore;
using TerraQuest.Models;

namespace TerraQuest.Data;

/// <summary>
/// Контекст базы данных TerraQuest.
/// Обеспечивает взаимодействие приложения с базой данных через Entity Framework Core.
/// </summary>
public class TerraQuestContext(DbContextOptions<TerraQuestContext> options) : DbContext(options)
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<CountryLanguage> CountryLanguages { get; set; }
    public DbSet<CountryFact>? CountryFacts { get; set; }
}