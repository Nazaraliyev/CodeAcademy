using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassTesk.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string Lastname { get; set; }


        [MaxLength(250)]
        public string Profile { get; set; }


        [NotMapped]
        public IFormFile ProfileFile { get; set; }

    }
}
