using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250)]
        public string Logo { get; set; }


        [MaxLength(200)]
        public string StartHeader { get; set; }


        [MaxLength(2000)]
        public string StartContent { get; set; }



        [MaxLength(250)]
        public string StartImage { get; set; }



        [NotMapped]
        public IFormFile StartImageFile { get; set; }



        [MaxLength(2000)]
        public string Description { get; set; }


        [MaxLength(250)]
        public string DescriptionImage1 { get; set; }


        [NotMapped]
        public IFormFile DescriptionImageFile1 { get; set; }



        [MaxLength(250)]
        public string DescriptionImage2 { get; set; }


        [NotMapped]
        public IFormFile DescriptionImageFile2 { get; set; }



        [MaxLength(300)]
        public string About { get; set; }


        [MaxLength(200)]
        public string Adress { get; set; }


        [MaxLength(50)]
        public string AdressIcon { get; set; }


        [MaxLength(100)]
        public string Email { get; set; }


        [MaxLength(50)]
        public string EmailIcon { get; set; }


        [MaxLength(15)]
        public string Phone { get; set; }


        [MaxLength(50)]
        public string PhoneIcon { get; set; }
    }
}
