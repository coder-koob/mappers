using AutoMapper;
using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.AutoMapper;

public class FilmProfile : Profile
{
    public FilmProfile()
    {
        CreateMap<Film, FilmDto>()
            .ForMember(
                x => x.TimeSinceRelease,
                x => x.MapFrom(src => DateTime.Now - src.ReleaseDate))
            .ReverseMap();
    }
}