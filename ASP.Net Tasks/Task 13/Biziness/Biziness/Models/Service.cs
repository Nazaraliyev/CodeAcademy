using System.ComponentModel.DataAnnotations;

namespace Biziness.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }



        [MaxLength(50), Required]
        public string Icon { get; set; }



        [MaxLength(300), Required]
        public string Content { get; set; }
    }
}
