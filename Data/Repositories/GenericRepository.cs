using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheroToHeroCRUDInVSCode
{
    #pragma warning disable // The field 'Program.studentRepository' is never used
    internal abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected NajotTalimDbContext _context = new NajotTalimDbContext();
        protected DbSet<T> dbSet {get; set;}

        public GenericRepository()
        {
            this.dbSet = _context.Set<T>();
        }
        
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> where = predicate ?? (x => true);
            return dbSet.Where(where);
 
        }
    }


}

#pragma warning disable // The field 'Program.studentRepository' is never used