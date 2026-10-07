using System.ComponentModel;

namespace TerraQuest.Models;

public enum Region
{
    [Description("Европа")] Europe,
    [Description("Северная Америка")] NorthAmerica,
    [Description("Южная Америка")] SouthAmerica,
    [Description("Австралия и Океания")] AustraliaAndOceania,
    [Description("Африка")] Africa,
    [Description("Азия")] Asia,
    [Description("Антарктида")] Antarctica
}