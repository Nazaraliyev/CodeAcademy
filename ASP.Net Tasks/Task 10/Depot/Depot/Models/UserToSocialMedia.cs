using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class UserToSocialMedia
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("CostumeUserId")]
        public int CostumeUserId { get; set; }
        public CostumeUser costumeUser { get; set; }




        [ForeignKey("SocialMediaId")]
        public int SocialMedia { get; set; }
        public UserSocialMedia userSocialMedia { get; set; }
    }
}
