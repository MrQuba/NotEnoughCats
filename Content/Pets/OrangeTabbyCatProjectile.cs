using NotEnoughCats.Common;
using NotEnoughCats.Content.Buff;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class OrangeTabbyCatProjectile : ModProjectile
	{
		private readonly Cat orangeCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			orangeCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			orangeCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			orangeCat.AI(Projectile, ModContent.BuffType<OrangeTabbyCatBuff>());
		}
	}
}