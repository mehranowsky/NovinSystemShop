using ModelLayer.Models;

namespace ServiceLayer.Services
{
    interface IUserService:IGenericService<User>
    {
        Task<bool> IsAdmin();
    }
}
