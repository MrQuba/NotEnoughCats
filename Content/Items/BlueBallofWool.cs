using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{
	public class BlueBallofWool : ModItem
	{
		BallofWool orangeWool = new();
		public override void SetDefaults()
		{
			orangeWool.SetDefaults(Item, ModContent.BuffType<RussianBlueCatBuff>(), ModContent.ProjectileType<RussianBlueCatProjectile>(), gold: 2, silver: 50);
		}
	}
}
