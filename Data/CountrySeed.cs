using TerraQuest.Models;

namespace TerraQuest.Data;

public class CountrySeed
{
    private List<Country> Countries { get; set; } = [];
    private int lastID;
    
    public void SeedCountries()
    {
        Country spain = new Country(lastID + 1, "Испания", "Мадрид",
            "Images/Flags/spain.png", "Евро", 48000000,
            505990.37, Region.Europe,
            "Испания занимает большую часть Пиренейского полуострова и имеет сухопутную границу" +
            " только с четырьмя странами: Португалией, Францией, Андоррой и Марокко (через территории Сеута и Мелилья).",
            ["Испанский", "Каталонский", "Галисийский",
            "Баскский", "Аранский"]);
        lastID++;
        Countries.Add(spain);
        Country canada = new Country(lastID + 1, "Канада", "Оттава",
            "Images/Flags/canada.png", "Канадский доллар", 41000000,
            9984670, Region.NorthAmerica,
            "Канада имеет самую длинную береговую линию в мире " +
            "и занимает второе место по площади среди стран мира",
            ["Английский", "Французский"]);
        lastID++;
        Countries.Add(canada);
        Country peru = new Country(lastID + 1, "Перу", "Лима",
            "Images/Flags/peru.png", "Перуанский соль", 34000000,
            1285216, Region.SouthAmerica,
            "В Перу находится древний город Мачу-Пикчу, " +
            "построенный цивилизацией инков высоко в Андах.",
            ["Испанский", "Кечуа", "Аймара"]);
        lastID++;
        Countries.Add(peru);
    }

    public IReadOnlyList<Country> GetCountries() => Countries;
}