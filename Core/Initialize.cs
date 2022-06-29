using Core.Interfaces;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class Initialize
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services.AddScoped<IMovieService, MovieService>();
    }
}