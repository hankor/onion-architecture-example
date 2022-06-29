using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Initialize
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IUnitOfWork, DatabaseContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IMovieRepository, MovieRepository>();
        return services;
    }
}