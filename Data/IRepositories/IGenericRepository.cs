using System.Threading.Tasks;

namespace TheroToHeroCRUDInVSCode 
{
    internal interface IGenericRepository<T> where T : class
    {
        public Task<T> Get(int Id);
    }
}