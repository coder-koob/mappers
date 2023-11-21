namespace Mappers._2023.Models;

public class Planet
{
    public string Name { get; set; }
    public int RotationPeriod { get; set; }
    public int OrbitalPeriod { get; set; }
    public int Diameter { get; set; }
    public string Climate { get; set; }
    public string Gravity { get; set; }
    public string Terrain { get; set; }
    public int SurfaceWater { get; set; }
    public long Population { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
}
