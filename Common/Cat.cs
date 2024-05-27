using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using NotEnoughCats.Content.Buff;

namespace NotEnoughCats.Common
{
	// base class for cats
	public class Cat
	{
		// sets static defaults and preview animation
		public void SetStaticDefaults(Projectile Projectile)
		{
			Main.projFrames[Projectile.type] = 4;
			Main.projPet[Projectile.type] = true;
			ProjectileID.Sets.CharacterPreviewAnimations[Projectile.type] = ProjectileID.Sets.SimpleLoop(0, Main.projFrames[Projectile.type], 12)
				.WithOffset(-10, 0)
				.WithSpriteDirection(-1)
				.WithCode(DelegateMethods.CharacterPreview.Float);
		}
		// sets defaults for pet
		public void SetDefaults(Projectile Projectile, int AIType)
		{
			Projectile.CloneDefaults(ProjectileID.BabyFaceMonster);
			Projectile.height = 28;
			Projectile.width = 34;
			AIType = -1;
			Main.projFrames[Projectile.type] = 4;
		}
		// AI of pet
		public void AI(Projectile Projectile, int buffType)
		{
			Player player = Main.player[Projectile.owner];
			int frameSpeed = 25;
			gravityForce(Projectile);
			Animate(Projectile, player, frameSpeed);
			isActive(Projectile, player, buffType);
		}
		// checks if there is solid tile below projectile
		private bool isSolidTileBelow(Projectile Projectile)
		{
			bool isSolidTileBelow = false;
			int tileX = (int)(Projectile.position.X / 16);
			int tileY = (int)((Projectile.position.Y + Projectile.height) / 16);

			if (WorldGen.SolidTile(tileX, tileY))
			{
				isSolidTileBelow = true;
			}
			return isSolidTileBelow;
		}
		// applies gravity force if projectile is floating
		private void gravityForce(Projectile Projectile)
		{
			Player player = Main.player[Projectile.owner];
			if (!isSolidTileBelow(Projectile) && !isPlayerMovingOnYAxis(player))
			{
				Projectile.velocity.Y += 0.981f;
			}
		}
		// checks if pet is active
		private bool isActive(Projectile Projectile, Player player, int buffType)
		{
			if (!player.dead && player.HasBuff(buffType))
			{
				Projectile.timeLeft = 2;
				return true;

			}
			return false;
		}
		// Plays animation if player is moving
		private bool isPlayerMovingOnXAxis(Player player)
		{
			return player.velocity.X != 0;
		}
		private bool isPlayerMovingOnYAxis(Player player)
		{
			return player.velocity.Y > 0;
		}
		private void Animate(Projectile Projectile, Player player, int frameSpeed)
		{

			if (!isPlayerMovingOnXAxis(player))
			{
				Projectile.frame = 0;
			}
			else
			{
				Projectile.frameCounter++;
				if (Projectile.frameCounter >= frameSpeed)
				{
					Projectile.frameCounter = 0;
					Projectile.frame++;
					if (Projectile.frame >= Main.projFrames[Projectile.type])
					{
						Projectile.frame = 0;
					}
				}
			}
		}
	}
}

