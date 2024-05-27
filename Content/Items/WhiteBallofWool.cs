using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{
	public class WhiteBallofWool : ModItem
	{
		BallofWool whiteWool = new();
		public override void SetDefaults()
		{
			whiteWool.SetDefaults(Item, ModContent.BuffType<WhiteCatBuff>(), ModContent.ProjectileType<WhiteCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
