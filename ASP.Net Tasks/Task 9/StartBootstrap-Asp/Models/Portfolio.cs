using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartBootstrap_Asp.Models
{
	public class Portfolio
	{
		[Key]
		public int Id { get; set; }


		[MaxLength(100)]
		public string ImgName { get; set; }

		[NotMapped]
        public IFormFile ImgFile { get; set; }



        [MaxLength(500)]
		public string ImgDescription { get; set; }

	}
}
