using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Lastname { get; set; }


        [MaxLength(100)]
        public string Fullname { get; set; }


        [MaxLength(200)]
        public string Image { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }


        public DateTime CreatedTime { get; set; }


        public List<Blog> blogs { get; set; }
        public List<Favourite> favourites { get; set; }
        public List<Cart> carts { get; set; }
    }
}
