namespace Mappers._2023.Dtos;

public class CharacterDto
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Mass { get; set; }
    public string HairColor { get; set; }
    public string SkinColor { get; set; }
    public string EyeColor { get; set; }
    public string BirthYear { get; set; }
    public string Gender { get; set; }
    public PlanetDto Homeworld { get; set; }
    public List<FilmDto> Films { get; set; }
    public SpeciesDto Species { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
}
