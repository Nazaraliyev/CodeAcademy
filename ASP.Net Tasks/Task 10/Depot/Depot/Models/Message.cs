using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }



        [MaxLength(100), Required]
        public string Mail { get; set; }



        [MaxLength(2000), Required]
        public string Content { get; set; }



        [MaxLength(300)]
        public string Website { get; set; }

    }
}
