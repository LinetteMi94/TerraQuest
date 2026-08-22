namespace TerraQuest.Models;

public class Language(string name)
{
    public int Id { get; internal set; }
    public string Name { get; internal set; } = name;
}