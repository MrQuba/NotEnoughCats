using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{ 
	public class OrangeBallofWool : ModItem
	{
		BallofWool orangeWool = new();
		public override void SetDefaults()
		{
			orangeWool.SetDefaults(Item, ModContent.BuffType<OrangeTabbyCatBuff>(), ModContent.ProjectileType<OrangeTabbyCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
