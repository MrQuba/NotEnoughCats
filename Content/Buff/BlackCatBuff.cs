﻿using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class BlackCatBuff : ModBuff
	{
		PetBuff blackCatBuff = new();
		public override void SetStaticDefaults()
		{
			blackCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			blackCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<BlackCatProjectile>());
		}
	}
}
