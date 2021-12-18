using System.ComponentModel.DataAnnotations;

namespace Oxu.az.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Image { get; set; }



        public News News { get; set; }
    }
}
