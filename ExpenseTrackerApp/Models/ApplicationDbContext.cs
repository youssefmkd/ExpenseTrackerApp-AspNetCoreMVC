using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerApp.Models
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{}

		public DbSet<transaction> Transactions { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
