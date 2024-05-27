using Microsoft.CodeAnalysis.CSharp.Syntax;
using NotEnoughCats.Content.Buff;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NotEnoughCats.Content.Pets
{
	public class BlackCatProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[Projectile.type] = 4;
			Main.projPet[Projectile.type] = true;
			ProjectileID.Sets.CharacterPreviewAnimations[Projectile.type] = ProjectileID.Sets.SimpleLoop(0, Main.projFrames[Projectile.type], 12)
				.WithOffset(-10, 0)
				.WithSpriteDirection(-1)
				.WithCode(DelegateMethods.CharacterPreview.Float);
		}

		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.BabyRedPanda);
			Projectile.height = 30;
			Projectile.width = 44;
			AIType = ProjectileID.BabyRedPanda;
		}
		public override void AI()
		{
			Player player = Main.player[Projectile.owner];
			int frameSpeed = 30;
			if(player.velocity.X == 0)
			{
				Projectile.frame = 0;
			}
			else{
				Projectile.frameCounter++;
				if (Projectile.frameCounter >= frameSpeed)
				{
					Projectile.frameCounter = 0;
					Projectile.frame++;
					if (Projectile.frame >= Main.projFrames[Projectile.type] - 1)
					{
						Projectile.frame = 0;
					}
				}
			}

			if (!player.dead && player.HasBuff(ModContent.BuffType<BlackCatBuff>()))
			{
				Projectile.timeLeft = 2;
			}
		}
	}
}