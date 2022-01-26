using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Biziness.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(50), Required]
        public string Name { get; set; }



        [MaxLength(50),Required]
        public string Surname { get; set; }


        public string Profile { get; set; }
    }
}
