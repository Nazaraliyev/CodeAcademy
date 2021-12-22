using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string Description { get; set; }


        [MaxLength(50)]
        public string Image { get; set; }
    }
}
