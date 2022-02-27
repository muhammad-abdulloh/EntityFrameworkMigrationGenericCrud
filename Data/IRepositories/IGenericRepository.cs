using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

/// <summary>
/// TheroToHeroCRUDInVSCode namespace
/// </summary>

namespace TheroToHeroCRUDInVSCode 
{
    /// <summary>
    /// IGenericRepository interface
    /// </summary>
    internal interface IGenericRepository<T> where T : class
    {


        /// <summary>
        /// Gets .
        /// </summary>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);  // Bu universal seearch hisobida keto'radi


        /// <summary>
        /// Create.
        /// </summary>
        /// <returns></returns>
        Task<T> CreateAsync(T entity);

        /// <summary>
        /// Delete.
        /// </summary>
        /// <returns></returns>
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Update.
        /// </summary>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

    }
}