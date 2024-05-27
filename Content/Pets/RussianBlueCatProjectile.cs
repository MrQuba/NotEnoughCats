using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class RussianBlueCatProjectile : ModProjectile
	{
		private readonly Cat blueCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			blueCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			blueCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			blueCat.AI(Projectile, ModContent.BuffType<RussianBlueCatBuff>());
		}
	}
}