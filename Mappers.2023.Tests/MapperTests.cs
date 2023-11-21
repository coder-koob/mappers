using System.Linq.Expressions;
using AutoFixture;
using AutoMapper;
using FluentAssertions;
using Mappers._2023.Dtos;
using Mappers._2023.Models;
using Mappers._2023.Services;
using Mapster;
using Moq;
using Xunit;

namespace Mappers._2023.Tests;

public class MapperTests
{
    private readonly Fixture _fixture = new Fixture();
    
    [Fact]
    public void AutoMapper_Should_Map_Character_To_CharacterDto()
    {
        // Arrange
        var character = _fixture.Create<Character>();
        var characterDto = _fixture.Create<CharacterDto>();

        var mapper = new Mock<IMapper>();

        mapper.Setup(x => x.Map<CharacterDto>(character))
            .Returns(characterDto);

        var sut = new CharacterService(mapper.Object);

        // Act
        var result = sut.GetCharacterDto(character);

        // Assert
        result.Should().BeEquivalentTo(characterDto);
    }
    
    [Fact]
    public void Mapster_StepInDebugging()
    {
        TypeAdapterConfig.GlobalSettings.Compiler = exp => exp.CompileWithDebugInfo();
        
        var character = _fixture.Create<Character>();

        character.Adapt<Character, CharacterDto>();
    }
}