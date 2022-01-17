using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class CostumeUser : IdentityUser
    {
        [MaxLength(50), Required]
        public string Name { get; set; }


        [MaxLength(50), Required]
        public string Lastname { get; set; }


        [MaxLength(100), Required]
        public string Fullname { get; set; }


        [MaxLength(250)]
        public string Profile {get; set;}


        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
