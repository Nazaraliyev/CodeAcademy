using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class UserSocialMedia
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
