using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }



        [MaxLength(50), Required]
        public string Icon { get; set; }



        [MaxLength(50), Required]
        public string Link { get; set; }

    }
}
