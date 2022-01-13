using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250)]
        public string Logo { get; set; }



        [MaxLength(250)]
        public string AboutBanner { get; set; }



        [MaxLength(1000)]
        public string AboutContent { get; set; }



        [MaxLength(1000)]
        public string AboutService { get; set; }




        [MaxLength(1000)]
        public string AboutHistory { get; set; }



        [MaxLength(250)]
        public string AboutImage { get; set; }



        [NotMapped]
        public IFormFile ImageFile { get; set; }




        [MaxLength(250)]
        public string FaqBanner { get; set; }
    }
}
