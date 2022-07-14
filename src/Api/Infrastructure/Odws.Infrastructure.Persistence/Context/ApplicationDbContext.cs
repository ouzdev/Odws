using Microsoft.EntityFrameworkCore;
using Odws.Api.Domain.Entities;

namespace Odws.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Note> Notes { get; set; } = null!;

       

    }
}
