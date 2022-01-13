using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_Asp.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50), Required]
        public string Name { get; set; }




        [MaxLength(50), Required]
        public string LastName { get; set; }



        [MaxLength(100)]
        public string FullName { get; set; }


        [MaxLength(200)]
        public string RePassword { get; set; }


        public DateTime CreatedTime { get; set; }
    }
}
