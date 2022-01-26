using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTesk.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Logo { get; set; }


        [NotMapped]
        public IFormFile LogoFile { get; set; }


        [MaxLength(500)]
        public string FooterAddress { get; set; }



        [MaxLength(500)]
        public string FooterPhone { get; set; }


        [MaxLength(500)]
        public string FooterMail { get; set; }
    }
}
