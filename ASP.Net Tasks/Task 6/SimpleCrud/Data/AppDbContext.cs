using Microsoft.EntityFrameworkCore;
using SimpleCrud.Models;

namespace SimpleCrud
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions options) :base(options)
		{

		}

		public DbSet<Employee> employees { get; set; }
		public DbSet<Position> position { get; set; }
	}
}
