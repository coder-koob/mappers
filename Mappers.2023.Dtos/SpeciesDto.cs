namespace Mappers._2023.Dtos;

public class SpeciesDto
{
    public string Name { get; set; }
    public string Classification { get; set; }
    public string Designation { get; set; }
    public int AverageHeight { get; set; }
    public string SkinColors { get; set; }
    public string HairColors { get; set; }
    public string EyeColors { get; set; }
    public int AverageLifespan { get; set; }
    public string Language { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public Uri Url { get; set; }
}
