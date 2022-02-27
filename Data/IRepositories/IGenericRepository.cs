using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TheroToHeroCRUDInVSCode 
{
    internal interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

    }
}