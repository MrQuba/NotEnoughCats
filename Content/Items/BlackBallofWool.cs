using NotEnoughCats.Content.Buff;
using NotEnoughCats.Content.Pets;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Items
{ 
	public class BlackBallofWool : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.BambooLeaf);
			Item.value = Item.buyPrice(gold: 2, silver: 50);
			Item.buffType = ModContent.BuffType<BlackCatBuff>();
			Item.buffTime = 100;
			Item.shoot = ModContent.ProjectileType<BlackCatProjectile>();
		}
	}
}
