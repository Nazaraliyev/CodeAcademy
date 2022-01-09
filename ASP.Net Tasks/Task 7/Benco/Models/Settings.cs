using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200)]
        public string Logo { get; set; }


        [NotMapped]
        public IFormFile LogoFile { get; set; } 



        [MaxLength(15)]
        public string Hotline { get; set; }



        [MaxLength(100)]
        public string HeaderText { get; set; }



        [MaxLength(1000)]
        public string ContactInfo { get; set; }



        [MaxLength(200)]
        public string Address { get; set; }



        [MaxLength(100)]
        public string Main { get; set; }



        [MaxLength(15)]
        public string Phone { get; set; }



        [MaxLength(200)]
        public string WorkTime { get; set; }



        [Column(TypeName = "ntext")]
        public string FAQInfo { get; set; }



        [MaxLength(100)]
        public string AboutImage1 { get; set; }



        [NotMapped]
        public IFormFile AboutImgFile1 { get; set; }



        [MaxLength(100)]
        public string AboutImage2 { get; set; }



        [NotMapped]
        public IFormFile AboutImgFile2 { get; set; }



        [Column(TypeName = "ntext")]
        public string AboutContent { get; set; }


        public int AboutAwards { get; set; }

        public int AboutProject { get; set; }

        public int AboutWorkHour { get; set; }
    }
}
