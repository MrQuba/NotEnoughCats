using NotEnoughCats.Content.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace NotEnoughCats.Common
{
	public class PetBuff
	{
		public void SetStaticDefaults(int Type)
		{
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}
		public void Update(Player player, ref int buffIndex, int projectile)
		{
			bool unused = false;
			player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, projectile);
		}
	}
}
