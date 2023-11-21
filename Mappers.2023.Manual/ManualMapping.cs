using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.Manual;

public static class ManualMapping
{
    public static CharacterDto MapToDto(this Character character)
    {
        var characterDto = new CharacterDto
        {
            Name = character.Name,
            Height = character.Height,
            Mass = character.Mass,
            HairColor = character.HairColor,
            SkinColor = character.SkinColor,
            EyeColor = character.EyeColor,
            BirthYear = character.BirthYear,
            Gender = character.Gender,
            Homeworld = MapPlanetToDto(character.Homeworld),
            Films = MapFilmsToDto(character.Films),
            Species = MapSpeciesToDto(character.Species),
            Created = character.Created,
            Edited = character.Edited
        };

        return characterDto;
    }

    private static List<FilmDto> MapFilmsToDto(List<Film> films)
    {
        var filmDtos = new List<FilmDto>(films.Count);
        
        foreach (var film in films)
        {
            filmDtos.Add(MapFilmToDto(film));
        }

        return filmDtos;
    }
    
    private static FilmDto MapFilmToDto(Film film)
    {
        var filmDto = new FilmDto
        {
            Title = film.Title,
            EpisodeId = film.EpisodeId,
            OpeningCrawl = film.OpeningCrawl,
            Director = film.Director,
            Producer = film.Producer,
            ReleaseDate = film.ReleaseDate,
            Created = film.Created,
            Edited = film.Edited
        };

        return filmDto;
    }
    
    private static SpeciesDto MapSpeciesToDto(Species species)
    {
        var speciesDto = new SpeciesDto
        {
            Name = species.Name,
            Classification = species.Classification,
            Designation = species.Designation,
            AverageHeight = species.AverageHeight,
            SkinColors = species.SkinColors,
            HairColors = species.HairColors,
            EyeColors = species.EyeColors,
            AverageLifespan = species.AverageLifespan,
            Language = species.Language,
            Created = species.Created,
            Edited = species.Edited
        };

        return speciesDto;
    }

    
    private static PlanetDto MapPlanetToDto(Planet planet)
    {
        var planetDto = new PlanetDto
        {
            Name = planet.Name,
            RotationPeriod = planet.RotationPeriod,
            OrbitalPeriod = planet.OrbitalPeriod,
            Diameter = planet.Diameter,
            Climate = planet.Climate,
            Gravity = planet.Gravity,
            Terrain = planet.Terrain,
            SurfaceWater = planet.SurfaceWater,
            Population = planet.Population,
            Created = planet.Created,
            Edited = planet.Edited
        };

        return planetDto;
    }

}