using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class RussianBlueCatBuff : ModBuff
	{
		PetBuff blueCatBuff = new();
		public override void SetStaticDefaults()
		{
			blueCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			blueCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<RussianBlueCatProjectile>());
		}
	}
}
