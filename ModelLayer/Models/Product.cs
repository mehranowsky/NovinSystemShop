using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }        
        public string Descreaption { get; set; }        
        public string ProductImage { get; set; }
        public int SellCount { get; set; }
        #region
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
