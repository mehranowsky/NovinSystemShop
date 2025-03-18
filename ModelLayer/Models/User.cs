using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        #region List
        public ICollection<Order> Orders { get; set; }
        #endregion        
    }
}
