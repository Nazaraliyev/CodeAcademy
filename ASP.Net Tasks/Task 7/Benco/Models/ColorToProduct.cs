using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class ColorToProduct
    {
        [Key]
        public int Id { get; set; }


        public decimal Price { get; set; }


        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [ForeignKey("ColorId")]
        public int ColorId { get; set; }
        public Color Color { get; set; }



        public List<ColorToSize> colorToSizes { get; set; }
    }
}
