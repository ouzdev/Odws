using Odws.Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Odws.Api.Application.Interfaces.Repository
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Sorgu üzerinde çalışmak istiyorsak IQueryable kullanıyoruz.
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);

    }
}
