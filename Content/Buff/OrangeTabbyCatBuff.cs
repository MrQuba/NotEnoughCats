﻿using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Pets;
using NotEnoughCats.Common;

namespace NotEnoughCats.Content.Buff
{
	public class OrangeTabbyCatBuff : ModBuff
	{
		PetBuff orangeCatBuff = new();
		public override void SetStaticDefaults()
		{
			orangeCatBuff.SetStaticDefaults(Type);
		}

		public override void Update(Player player, ref int buffIndex)
		{
			orangeCatBuff.Update(player, ref buffIndex, ModContent.ProjectileType<OrangeTabbyCatProjectile>());
		}
	}
}
