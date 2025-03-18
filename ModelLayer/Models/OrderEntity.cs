using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer.Models
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(int.MinValue, 20)]
        public int Price { get; set; }
        [Required]
        [Range(int.MinValue, 10)]
        public int Count { get; set; }
        #region
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        #endregion
    }
}
