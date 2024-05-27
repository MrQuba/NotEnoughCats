using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class SiameseCatProjectile : ModProjectile
	{
		private readonly Cat grayCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			grayCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			grayCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			grayCat.AI(Projectile, ModContent.BuffType<SiameseCatBuff>());
		}
	}
}