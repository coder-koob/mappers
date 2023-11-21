using Mappers._2023.Models;

namespace Mappers._2023.TestData;

public static class TestData
{
    public static Character CreateMock()
    {
        var lukeSkywalker = new Character
        {
            Name = "Luke Skywalker",
            Height = 172,
            Mass = 77,
            HairColor = "blond",
            SkinColor = "fair",
            EyeColor = "blue",
            BirthYear = "19BBY",
            Gender = "male",
            Homeworld = new Planet
            {
                Name = "Tatooine",
                RotationPeriod = 23,
                OrbitalPeriod = 304,
                Diameter = 10465,
                Climate = "arid",
                Gravity = "1 standard",
                Terrain = "desert",
                SurfaceWater = 1,
                Population = 200000,
                Created = DateTime.Now,
                Edited = DateTime.Now
            },
            Films = new List<Film>
            {
                new Film
                {
                    Title = "A New Hope",
                    EpisodeId = 4,
                    Director = "George Lucas",
                    ReleaseDate = new DateTime(1977, 5, 25),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                },
                new Film
                {
                    Title = "The Empire Strikes Back",
                    EpisodeId = 5,
                    Director = "Irvin Kershner",
                    ReleaseDate = new DateTime(1980, 5, 21),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                },
                new Film
                {
                    Title = "Return of the Jedi",
                    EpisodeId = 6,
                    Director = "Richard Marquand",
                    ReleaseDate = new DateTime(1983, 5, 25),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                },
                new Film
                {
                    Title = "The Force Awakens",
                    EpisodeId = 7,
                    Director = "J.J. Abrams",
                    ReleaseDate = new DateTime(2015, 12, 18),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                },
                new Film
                {
                    Title = "The Last Jedi",
                    EpisodeId = 8,
                    Director = "Rian Johnson",
                    ReleaseDate = new DateTime(2017, 12, 15),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                },
                new Film
                {
                    Title = "The Rise of Skywalker",
                    EpisodeId = 9,
                    Director = "J.J. Abrams",
                    ReleaseDate = new DateTime(2019, 12, 20),
                    Created = DateTime.Now,
                    Edited = DateTime.Now
                }
            },
            Species = new Species
            {
                Name = "Human",
                Classification = "mammal",
                Designation = "sentient",
                AverageHeight = 180,
                SkinColors = "caucasian, black, asian, hispanic",
                HairColors = "blonde, brown, black, red",
                EyeColors = "brown, blue, green, hazel, grey, amber",
                AverageLifespan = 120,
                Language = "Galactic Basic",
                Created = DateTime.Now,
                Edited = DateTime.Now
            },
            Created = DateTime.Now,
            Edited = DateTime.Now
        };

        return lukeSkywalker;
    }
}