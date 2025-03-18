using Microsoft.AspNetCore.Identity;

namespace ModelLayer.Models
{
    public class User : IdentityUser
    {        
        #region List
        public ICollection<Order> Orders { get; set; }
        #endregion        
    }
}
