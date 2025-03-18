using ModelLayer.Context;
using ModelLayer.Models;

namespace ServiceLayer.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(NovinSystemDbContext context) : base(context)
        {
        }

        public Task<bool> IsAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
