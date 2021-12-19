using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SixteenClothing.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Img { get; set; }




        [MaxLength(50)]
        public string Name { get; set; }




        [Column(TypeName = "ntext")]
        public string Text { get; set; }



        public int Price { get; set; }



        [Column(TypeName = "tinyint")]
        public byte Star { get; set; }


        public int Preview { get; set; }
    }
}
