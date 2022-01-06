using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCrud.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }



		[MaxLength(50)]
		public string Name { get; set; }



		[MaxLength(50)]
		public string LastName { get; set; }



		[MaxLength(50)]
		public string FullName { get; set; }



		public int Age { get; set; }



		[MaxLength(50)]
		public string Email { get; set; }



		[ForeignKey("PositionId")]
		public Position position { get; set; }
		public int PositionId { get; set; }

	}
}
