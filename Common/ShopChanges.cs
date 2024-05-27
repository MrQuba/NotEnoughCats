using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Items;

namespace NotEnoughCats.Common
{
	public class ShopChanges : GlobalNPC
	{
		public override void ModifyShop(NPCShop shop)
		{
			int type = shop.NpcType;
			if (type == NPCID.BestiaryGirl)
			{
				shop.Add(ModContent.ItemType<BlackBallofWool>(), Condition.HappyEnough);
				shop.Add(ModContent.ItemType<OrangeBallofWool>(), Condition.HappyEnough);
				shop.Add(ModContent.ItemType<BlueBallofWool>(), Condition.HappyEnough);
				shop.Add(ModContent.ItemType<WhiteBallofWool>(), Condition.HappyEnough);
				shop.Add(ModContent.ItemType<SilverBallofWool>(), Condition.HappyEnough);
				shop.Add(ModContent.ItemType<GrayBallofWool>(), Condition.HappyEnough);
			}
		}
	}
}
