using Microsoft.EntityFrameworkCore;
using ModelLayer.Context;
using ModelLayer.Models;
using System.Collections;

namespace RepositoryLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private readonly NovinSystemDbContext _context;
        private readonly DbSet<T> _Table;
        public GenericRepository(NovinSystemDbContext context)
        {
            _context = context;
            _Table = context.Set<T>();
        }
        public async Task<IEnumerable> GetAll()
        {
            return await _Table.ToListAsync();
        }

        public async Task<T> GetEntity(int id)
        {
            return await _Table.FindAsync(id);
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await _Table.AddAsync(entity);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Update(T entity)
        {
            try
            {
                _Table.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                _Table.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var entity = await GetEntity(id);
                if(entity != null)
                {
                    _Table.Remove(entity);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }        

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }
    }
}
