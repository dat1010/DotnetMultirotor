using Microsoft.EntityFrameworkCore;
using DotnetMultirotor.Models;

namespace DotnetMultirotor.Persistence
{
	public class DotnetMultirotorContext : DbContext
	{
		public DotnetMultirotorContext(DbContextOptions<DotnetMultirotorContext> options) :base(options) { }

		public DbSet<User> Users {get; set;}
		public DbSet<Post> Posts {get; set;}

	}
																				 
}

