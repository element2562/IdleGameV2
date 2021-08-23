using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdleGameV2.Entities
{
	public class Zone
	{
		[Key]
		public int Id { get; set; }
		public int Level { get; set; }
		public ICollection<Monster> Monsters { get; set; }
		public ICollection<Item> Items { get; set; }
	}
}
