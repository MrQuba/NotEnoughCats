using Terraria.ID;
using Terraria;

namespace NotEnoughCats.Common
{
	public class BallofWool
	{
		public void SetDefaults(Item Item, int buff, int projectile, int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			Item.CloneDefaults(ItemID.BambooLeaf);
			Item.value = Item.buyPrice(platinum: platinum, gold: gold, silver: silver, copper: copper);
			Item.buffType = buff;
			Item.buffTime = 100;
			Item.shoot = projectile;
		}
	}
}
