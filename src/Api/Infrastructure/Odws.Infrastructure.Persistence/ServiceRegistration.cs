using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Odws.Api.Application.Interfaces.Repository;
using Odws.Infrastructure.Persistence.Context;
using Odws.Infrastructure.Persistence.Repositories;

namespace Odws.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services, IConfiguration config)
        {
            var constr = config.GetConnectionString("PostgreSQLConnection");
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseNpgsql(constr);
            });
            
           services.AddScoped<INoteRepository, NoteRepository>();
        }
    }
}
