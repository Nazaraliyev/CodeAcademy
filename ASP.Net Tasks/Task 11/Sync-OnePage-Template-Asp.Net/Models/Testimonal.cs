using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Testimonal
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100), Required]
        public string Author { get; set; }


        [MaxLength(100), Required]
        public string Position { get; set; }


        [MaxLength(1000), Required]
        public string Content { get; set; }


        [Column(TypeName = "tinyint"), Required]
        public byte Star { get; set; }
    }
}
