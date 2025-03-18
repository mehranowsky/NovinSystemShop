using ModelLayer.Context;
using ModelLayer.Models;
using RepositoryLayer;

namespace ServiceLayer
{
    public class GenericService<T> : GenericRepository<T> where T : BaseEntity
    {
        public GenericService(NovinSystemDbContext context):base(context)
        {
            
        }
    }
}
