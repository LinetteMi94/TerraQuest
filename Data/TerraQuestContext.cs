using Microsoft.EntityFrameworkCore;
using TerraQuest.Models;

namespace TerraQuest.Data;

public class TerraQuestContext(DbContextOptions<TerraQuestContext> options) : DbContext(options)
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<CountryLanguage> CountryLanguages { get; set; }
}