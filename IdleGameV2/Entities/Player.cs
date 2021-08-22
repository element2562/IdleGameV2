using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdleGameV2.Entities
{
	public class Player
	{
		[Key]
		public int Id { get; set; }
		public string UserName { get; set; }
		public int Gold { get; set; }
		public int Level { get; set; }
		public int Experience { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public int Defense { get; set; }
		public int Speed { get; set; }
		public int MagicFind { get; set; }
		public virtual ICollection<Item> Items { get; set; }
		public virtual ICollection<Item> EquippedItems { get; set; }
	}
}
