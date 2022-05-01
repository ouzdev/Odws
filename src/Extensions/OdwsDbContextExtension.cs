using Microsoft.EntityFrameworkCore;
using Odws.Models;

public static class OdwsDbContextExtension
{

    public static IServiceCollection UseOdwsDbContext(this IServiceCollection services, WebApplicationBuilder options)
    {
        var connectionString = options.Configuration["PostgreSQLConnection"];
        services.AddDbContext<OdwsDatabaseContext>(x => x.UseNpgsql(connectionString));
        return services;
    }
}

