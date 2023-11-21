namespace Mappers._2023.Models;

public class Character
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Mass { get; set; }
    public string HairColor { get; set; }
    public string SkinColor { get; set; }
    public string EyeColor { get; set; }
    public string BirthYear { get; set; }
    public string Gender { get; set; }
    public Planet Homeworld { get; set; }
    public List<Film> Films { get; set; }
    public Species Species { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
}
