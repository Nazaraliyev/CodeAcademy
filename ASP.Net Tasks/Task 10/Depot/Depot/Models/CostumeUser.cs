using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50), Required]
        public string Name { get; set; }




        [MaxLength(50), Required]
        public string Lastname { get; set; }




        [MaxLength(50)]
        public string Fullname { get; set; }




        [Required]
        public DateTime DayOfBirth { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }


        public List<Blog> blogs { get; set; }
        public List<UserToSocialMedia> userToSosialMedias { get; set; }
        public List<Wish> wish { get; set; }
        public List<Cart> carts { get; set; }
        public List<ProductComment> productComments { get; set; }
        public List<BlogComment> blogComments { get; set; }
    }
}
