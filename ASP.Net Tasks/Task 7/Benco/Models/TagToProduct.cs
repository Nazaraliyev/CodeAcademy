using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class TagToProduct
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Productid")]
        public int ProductId { get; set; }
        public Product Product { get; set; }



        [ForeignKey("ProductTag")]
        public int ProductTagId { get; set; }
        public ProductTag productTag { get; set; }

    }
}
