using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdleGameV2.Entities
{
	public class Shop
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Item> ItemsForSale { get; set; }
	}
}
