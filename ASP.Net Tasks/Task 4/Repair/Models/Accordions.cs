using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class Accordions
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string Content { get; set; }
    }
}
