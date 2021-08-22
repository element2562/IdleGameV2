using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdleGameV2.Entities
{
	public class Monster
	{
		[Key]
		public int Id { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public int Defense { get; set; }
		public int Speed { get; set; }
		public int Level { get; set; }
		public bool IsDead { get; set; }
		public int GoldToDrop { get; set; }
		public virtual ICollection<Item> ItemsToDrop { get; set; }
	}
}
