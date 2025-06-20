using HotelListingApi.Contracts;
using HotelListingApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListingDbContext _context;

        public GenericRepository(HotelListingDbContext context)
        {
            this._context = context;
        }

        public async Task<T> AddAsync(T Entity)
        {
            await _context.AddAsync(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }

        public async Task DeleteAsync(int? id)
        {
            var entity = await GetAsync(id);
            _context.Set<T>().Remove(entity); 
            await _context.SaveChangesAsync();

        }

        public async Task<bool> Exists(int? id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();   
        }

        public async Task<T> GetAsync(int? id)
        {
            if(id==null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T Entity)
        {
           _context.Update(Entity);
            await _context.SaveChangesAsync();
        }
    }
}
