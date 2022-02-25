using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheroToHeroCRUDInVSCode
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected NajotTalimDbContext _context = new NajotTalimDbContext();
        protected DbSet<T> dbSet {get; set;}

        public GenericRepository()
        {
            this.dbSet = _context.Set<T>();
        }
        
        public async Task<T> Get(int Id)
        {
            return await dbSet.FindAsync(Id);
        }
    }


}