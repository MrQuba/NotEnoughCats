using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Items;

namespace NotEnoughCats.Common
{
	public class ZoologistShop : GlobalNPC
	{
		public override void ModifyShop(NPCShop shop)
		{
			int type = shop.NpcType;
			if (type == NPCID.BestiaryGirl)
			{
				// 5453 is Guide to Critter Companionship: https://terraria.wiki.gg/wiki/Guide_to_Critter_Companionship
				shop.Add(ModContent.ItemType<BlackBallofWool>(), Condition.NotBloodMoon);
			}
		}
	}
}
