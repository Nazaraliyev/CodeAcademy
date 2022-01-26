using System.ComponentModel.DataAnnotations;

namespace Biziness.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }



        [MaxLength(100), Required]
        public string Email { get; set; }



        [MaxLength(2000), Required]
        public string Content { get; set; }
    }
}
