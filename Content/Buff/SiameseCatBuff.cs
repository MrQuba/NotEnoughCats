using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class SiameseCatBuff : ModBuff
	{
		PetBuff grayCatBuff = new();
		public override void SetStaticDefaults()
		{
			grayCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			grayCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<SiameseCatProjectile>());
		}
	}
}
