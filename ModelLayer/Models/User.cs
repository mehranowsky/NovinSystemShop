using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        #region
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}
