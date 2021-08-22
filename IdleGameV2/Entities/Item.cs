using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdleGameV2.Entities
{
	public class Item
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Player")]
		public int PlayerId { get; set; }
		public int StrengthBonus { get; set; }
		public int DefenseBonus { get; set; }
		public int HealthBonus { get; set; }
		public int SpeedBonus { get; set; }

		public virtual Player player { get; set; }
	}
}
