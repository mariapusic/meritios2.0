using Microsoft.EntityFrameworkCore;
using NiceLIA.Models.Domain;

namespace NiceLIA.Data
{
	public class UserDbContext : DbContext
	{
		public UserDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<User> _Users { get; set; }
	}
}
