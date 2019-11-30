using Terraria.ModLoader;
using Terraria;

namespace CameraPlayer
{
	public class CameraPlayer : ModPlayer
	{
        public override void ModifyScreenPosition()
        {
            int num7 = Main.mouseX;
            int num8 = Main.mouseY;
            if (num7 > Main.screenWidth)
            {
                num7 = Main.screenWidth;
            }
            if (num7 < 0)
            {
                num7 = 0;
            }
            if (num8 > Main.screenHeight)
            {
                num8 = Main.screenHeight;
            }
            if (num8 < 0)
            {
                num8 = 0;
            }
            float num3 = (num7 - Main.screenWidth / 2) / 8f;
            float num4 = (num8 - Main.screenHeight / 2) / 8f;
            Main.screenPosition.X += num3;
            Main.screenPosition.Y += num4 * Main.player[Main.myPlayer].gravDir;

        }
    }
}