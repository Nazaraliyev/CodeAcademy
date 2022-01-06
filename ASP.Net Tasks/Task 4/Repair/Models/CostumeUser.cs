using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class CostumeUser:IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }




        [MaxLength(50)]
        public string Surname { get; set; }



        [MaxLength(100)]
        public string Fullname { get; set; }


        [MaxLength(50)]
        public string Adress { get; set; }


        public DateTime CreateTime { get; set; }
    }
}
