using AutoMapper;
using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.AutoMapper;

public class SpeciesProfile : Profile
{
    public SpeciesProfile()
    {
        CreateMap<Species, SpeciesDto>().ReverseMap();
    }
}