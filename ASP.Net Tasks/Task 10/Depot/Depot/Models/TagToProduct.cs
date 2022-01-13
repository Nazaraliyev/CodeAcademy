using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class TagToProduct
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }




        [ForeignKey("ProductTagId")]
        public int ProductTagId { get; set; }
        public ProductTag ProductTag { get; set; }
    }
}
