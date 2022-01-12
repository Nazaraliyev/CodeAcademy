using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleCrud.Models;

namespace SimpleCrud
{
	public class AppDbContext:IdentityDbContext
	{
		public AppDbContext(DbContextOptions options) :base(options)
		{

		}

		public DbSet<Employee> employees { get; set; }
		public DbSet<Position> position { get; set; }
		public DbSet<CostumeUser> costumeUsers { get; set; }
	}
}
