using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [ForeignKey("SizeId")]
        public int SizeId { get; set; }
        public Size Size { get; set; }



        [ForeignKey("ColorId")]
        public int ColorId { get; set; }
        public Color Color { get; set; }


        public int Count { get; set; }



    }
}
