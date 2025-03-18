using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public int Price { get; set; }
        [MaxLength(200)]
        public string Descreaption { get; set; }
        [MaxLength(50)]
        public string ProductImage { get; set; }
        [Required]
        [MaxLength(5)]
        public int Count { get; set; }
        [Required]
        [MaxLength(20)]
        public int SellCount { get; set; } = 0;
        #region
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
