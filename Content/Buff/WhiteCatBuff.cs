using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class WhiteCatBuff : ModBuff
	{
		PetBuff whiteCatBuff = new();
		public override void SetStaticDefaults()
		{
			whiteCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			whiteCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<WhiteCatProjectile>());
		}
	}
}
