using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCrud.Models
{
    public class CostumeUser:IdentityUser
	{
		[MaxLength(200)]
		public string Image { get; set; }



		[NotMapped]
		public IFormFile formFile { get; set; }


		[MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(50)]
        public string Lastname { get; set; }



        [MaxLength(100)]
        public string Fullname { get; set; }



        public int Age { get; set; }


        [NotMapped]
        public string RePassword { get; set; }



        [NotMapped]
        public string RollId { get; set; }
    }
}
