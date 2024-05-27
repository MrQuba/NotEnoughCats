using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{
	public class GrayBallofWool : ModItem
	{
		BallofWool grayWool = new();
		public override void SetDefaults()
		{
			grayWool.SetDefaults(Item, ModContent.BuffType<SiameseCatBuff>(), ModContent.ProjectileType<SiameseCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
