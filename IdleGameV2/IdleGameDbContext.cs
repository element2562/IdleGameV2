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

			Player player = new Player()
			{
				Id = 1,
				UserName = "default",
				Level = 1,
				Experience = 0,
				Strength = 0,
				Defense = 0,
				Speed = 0,
				Gold = 50,
				Health = 100,
				MagicFind = 5
			};

			modelBuilder.Entity<Player>().HasData(player);
		}
	}
}
