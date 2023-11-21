using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Mappers._2023.AutoMapper;
using Mappers._2023.Dtos;
using Mappers._2023.Manual;
using Mappers._2023.Mapperly;
using Mappers._2023.Models;
using Mappers._2023.TinyMapper;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Mappers._2023.Benchmarks;

[MemoryDiagnoser(false)]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class Benchmarks
{
    private readonly Character _character = TestData.TestData.CreateMock();
    
    private readonly IMapper _autoMapper;
    private readonly MapperlyMapper _mapperlyMapper;

    public Benchmarks()
    {
        // AutoMapper
        var services = new ServiceCollection();
        services.ConfigureAutoMapper();
        var serviceProvider = services.BuildServiceProvider();
        _autoMapper = serviceProvider.GetRequiredService<IMapper>();
        
        // Mapperly
        _mapperlyMapper = new MapperlyMapper();
        
        // Tiny Mapper
        TinyMapperConfig.Setup();
        
        // Mapster no setup needed
    }

    [Benchmark]
    public CharacterDto Automapper()
    {
        return _autoMapper.Map<CharacterDto>(_character);
    }
    
    [Benchmark]
    public CharacterDto Mapperly()
    {
        return _mapperlyMapper.Map(_character);
    }
    
    [Benchmark]
    public CharacterDto TinyMapper()
    {
        return Nelibur.ObjectMapper.TinyMapper.Map<CharacterDto>(_character);
    }
    
    [Benchmark]
    public CharacterDto Mapster()
    {
        return _character.Adapt<CharacterDto>();
    }

    [Benchmark]
    public CharacterDto Manual()
    {
        return _character.MapToDto();
    }
}