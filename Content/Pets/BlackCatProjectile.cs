using NotEnoughCats.Content.Buff;
using NotEnoughCats.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class BlackCatProjectile : ModProjectile
	{
		private readonly Cat blackCat = new();
		// sets static defaults and preview animation
		public override void SetStaticDefaults()
		{
			blackCat.SetStaticDefaults(Projectile);
		}
		// sets defaults for pet
		public override void SetDefaults()
		{
			blackCat.SetDefaults(Projectile, AIType);
		}
		// AI of pet
		public override void AI()
		{
			blackCat.AI(Projectile);
		}
	}
}