using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_2_ASP.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string Lastname { get; set; }



        [MaxLength(100)]
        public string Fullname { get; set; }
    }
}
