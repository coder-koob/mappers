using AutoMapper;
using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.Services;

public class CharacterService
{
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public CharacterDto GetCharacterDto(Character character)
    {
        return _mapper.Map<CharacterDto>(character);
    }
}