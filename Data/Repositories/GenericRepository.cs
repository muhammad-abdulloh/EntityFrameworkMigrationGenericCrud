using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

/// <summary>
/// TheroToHeroCRUDInVSCode namespace
/// </summary>

namespace TheroToHeroCRUDInVSCode
{
    /// <summary>
    /// GenericRepository class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    #pragma warning disable // The field 'Program.studentRepository' is never used
    internal abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        /// <summary>
        /// The _context
        /// </summary>
        /// <value>
        /// The _context
        /// </value>
        protected NajotTalimDbContext _context = new NajotTalimDbContext();
        protected DbSet<T> dbSet {get; set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        
        public GenericRepository()
        {
            this.dbSet = _context.Set<T>();
        }
        

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }


        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> where = predicate ?? (x => true);
            return dbSet.Where(where);
 
        }

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>

        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entry = await dbSet.AddAsync(entity);  
            await _context.SaveChangesAsync();
            return (T)entry.Entity;
        }


        /// <summary>
        /// Deletes the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            
            var entity = await dbSet.FirstOrDefaultAsync(predicate);

            if (entity is null)
            {
                return false;
            }
            dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }


        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;  // 1 - update qilish usuli

            //var entry = dbSet.Update(entity); // 2 - update qilish usuli

            await _context.SaveChangesAsync();
            return entity;
        }


    }


}

#pragma warning disable // The field 'Program.studentRepository' is never used