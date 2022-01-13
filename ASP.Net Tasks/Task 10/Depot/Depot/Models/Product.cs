using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200), Required]
        public string Name { get; set; }



        [MaxLength(2000)]
        public string Info { get; set; }



        [ForeignKey("BrendId")]
        public int BrendId { get; set; }
        public Brend Brend { get; set; }



        [ForeignKey("ProductCategoryId")]
        public int ProductCategoryId { get; set; }
        public ProductCategory productCategory { get; set; }



        public List<ProductImage> productImages { get; set; }
        public List<TagToProduct> tagToProducts { get; set; }
        public List<ColorToProduct> colorToProducts { get; set; }
    }
}
