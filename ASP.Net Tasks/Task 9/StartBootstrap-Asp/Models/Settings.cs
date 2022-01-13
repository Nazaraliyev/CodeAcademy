using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartBootstrap_Asp.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



		[MaxLength(50)]
		public string Logo { get; set; }



		[MaxLength(500)]
		public string Location { get; set; }



		[MaxLength(500)]
		public string FreelancerAbout { get; set; }



		[MaxLength(100)]
		public string BannerImg { get; set; }



		[NotMapped]
		public IFormFile formFile { get; set; }



		[MaxLength(200)]
		public string BannerHeader { get; set; }



		[MaxLength(200)]
		public string BannerText { get; set; }



		[Column(TypeName = "ntext")]
		public string AboutText { get; set; }
	}
}
