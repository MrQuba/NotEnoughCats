using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class WhiteCatProjectile : ModProjectile
	{
		private readonly Cat whiteCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			whiteCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			whiteCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			whiteCat.AI(Projectile, ModContent.BuffType<WhiteCatBuff>());
		}
	}
}