using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.Models
{
    public class Order 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        [Range(int.MinValue, 20)]
        public int Sum { get; set; }
        [MaxLength(10)]
        public string DiscountCode { get; set; }
        [Required]
        public bool IsFinally { get; set; }
        #region
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public ICollection<OrderEntity> OrderEntities { get; set; }
        #endregion
    }
}
