using Mappers._2023.Dtos;
using Mappers._2023.Models;

namespace Mappers._2023.TinyMapper;

public static class TinyMapperConfig
{
    public static void Setup()
    {
        Nelibur.ObjectMapper.TinyMapper.Bind<Character, CharacterDto>();
    }
}