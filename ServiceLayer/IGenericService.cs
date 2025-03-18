using RepositoryLayer;
using ModelLayer.Models;

namespace ServiceLayer
{
    public interface IGenericService<T> where T:BaseEntity
    {
    }
}
