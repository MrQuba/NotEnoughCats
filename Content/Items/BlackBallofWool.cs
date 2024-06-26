using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{ 
	public class BlackBallofWool : ModItem
	{
		BallofWool blackWool = new();
		public override void SetDefaults()
		{
			blackWool.SetDefaults(Item, ModContent.BuffType<BlackCatBuff>(), ModContent.ProjectileType<BlackCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
