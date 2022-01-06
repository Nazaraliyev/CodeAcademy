using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleCrud.Models
{
	public class Position
	{
		[Key]
		public int Id { get; set; }


		[MaxLength(50)]
		public string Name { get; set; }


		public List<Employee> employees { get; set; }
	}
}
