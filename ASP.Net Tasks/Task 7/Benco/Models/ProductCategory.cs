using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [ForeignKey("ProductCategoryId")]
        public int ProductCategoryId { get; set; }
        public ProductCategory productCategory { get; set; }


        public List<Product> products { get; set; }
    }
}
