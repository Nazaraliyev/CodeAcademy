using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Stor
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100), Required]
        public string Name { get; set; }


        [MaxLength(500), Required]
        public string Address { get; set; }
    }
}
