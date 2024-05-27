using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class SilverCatBuff : ModBuff
	{
		PetBuff silverCatBuff = new();
		public override void SetStaticDefaults()
		{
			silverCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			silverCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<SilverCatProjectile>());
		}
	}
}
