using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biziness.View_Model
{
	public class VmUserCreate
	{
		[MaxLength(50), Required]
		public string Name { get; set; }



		[MaxLength(50), Required]
		public string Surname { get; set; }


		[MaxLength(100), Required, EmailAddress]
		public string Email { get; set; }


		[MaxLength(15), Required, Phone]
		public string Phone { get; set; }


		[MaxLength(100), Required]
		public string Password { get; set; }



		[MaxLength(15), Required, Display(Name = "Confirm Password"), Compare("Password")]
		public string CoPassword { get; set; }



	}
}
