using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SixteenClothing.Models
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(50)]
        public string Fullname { get; set; }




        [MaxLength(50)]
        public string Mail { get; set; }




        [MaxLength(50)]
        public string Subject { get; set; }



        [Column(TypeName = "ntext")]
        public string Text { get; set; }
    }
}
