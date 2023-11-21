using AutoMapper;
using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.AutoMapper;

public class CharacterProfile : Profile
{
    public CharacterProfile()
    {
        CreateMap<Character, CharacterDto>().ReverseMap();
    }
}