using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{
	public class SilverBallofWool : ModItem
	{
		BallofWool silverWool = new();
		public override void SetDefaults()
		{
			silverWool.SetDefaults(Item, ModContent.BuffType<SilverCatBuff>(), ModContent.ProjectileType<SilverCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
