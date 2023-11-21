using Mappers._2023.Dtos;
using Mappers._2023.Models;
using Riok.Mapperly.Abstractions;

namespace Mappers._2023.Mapperly;

[Mapper]
public partial class MapperlyMapper
{
    public partial CharacterDto Map(Character character);
}