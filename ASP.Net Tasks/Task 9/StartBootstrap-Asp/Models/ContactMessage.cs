using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_Asp.Models
{
	public class ContactMessage
	{
		[Key]
		public int Id { get; set; }



		[MaxLength(100)]
		public string FullName { get; set; }


		[MaxLength(100)]
		public string Email { get; set; }



		[MaxLength(15)]
		public string Phone { get; set; }



		[MaxLength(2000)]
		public string Message { get; set; }
	}
}
