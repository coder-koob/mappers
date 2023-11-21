using Microsoft.Extensions.DependencyInjection;

namespace Mappers._2023.AutoMapper;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CharacterProfile));

        return services;
    }
}