using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.Models
{
    public class Order : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public int Sum { get; set; }
        public string DiscountCode { get; set; }
        [Required]
        public bool IsFinally { get; set; }
        #region
        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
