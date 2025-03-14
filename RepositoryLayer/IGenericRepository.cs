using System.Collections;

namespace RepositoryLayer
{
    public interface IGenericRepository<T>:IDisposable
    {
        Task<IEnumerable> GetAll();
        Task<T> GetEntity(int id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Delete(int id);
        void Save();
    }
}
