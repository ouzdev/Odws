using Odws.Api.Application.Interfaces.Repository;
using Odws.Api.Domain.Entities;
using Odws.Infrastructure.Persistence.Context;


namespace Odws.Infrastructure.Persistence.Repositories
{
    public class NoteRepository:GenericRepository<Note>,INoteRepository
    {
        public NoteRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
