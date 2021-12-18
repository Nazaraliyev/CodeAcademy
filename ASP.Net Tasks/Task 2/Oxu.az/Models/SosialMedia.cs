using System.ComponentModel.DataAnnotations;

namespace Oxu.az.Models
{
    public class SosialMedia
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(100)]
        public string Link { get; set; }

    }
}
