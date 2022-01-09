using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class ColorToSize
    {
        [Key]
        public int Id { get; set; }


        public int Count { get; set; }


        [ForeignKey("SizeId")]
        public int SizeId { get; set; }
        public Size Size { get; set; }


        [ForeignKey("ColorToProductId")]
        public int ColorToProductId { get; set; }
        public ColorToProduct colorToProduct { get; set; }
    }
}
