using Microsoft.EntityFrameworkCore;
using Odws.Api.Application.Interfaces.Repository;
using Odws.Api.Domain.Common;
using Odws.Infrastructure.Persistence.Context;

namespace Odws.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T:BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
           await _context.SaveChangesAsync();
           return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
