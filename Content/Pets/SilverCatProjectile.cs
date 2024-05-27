using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class SilverCatProjectile : ModProjectile
	{
		private readonly Cat silverCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			silverCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			silverCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			silverCat.AI(Projectile, ModContent.BuffType<SilverCatBuff>());
		}
	}
}