using IdleGameV2.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdleGameV2
{
	public class IdleGameDbContext : DbContext
	{
		public IdleGameDbContext(DbContextOptions<IdleGameDbContext> options) : base(options)
		{
		}
		DbSet<Player> Player { get; set; }
		DbSet<Item> Item { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
