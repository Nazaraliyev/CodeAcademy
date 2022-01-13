using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Mail { get; set; }
    }
}
