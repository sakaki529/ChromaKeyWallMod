using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;

namespace ChromaKeyWallMod
{
    internal static class ChromaKeyWallMethod
    {
        public static void DrawWalls(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int type = tile.WallType;
            Rectangle value2 = new(tile.WallFrameX, tile.WallFrameY, 32, 32);
            Vector2 zero = new(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            Main.spriteBatch.Draw(TextureAssets.Wall[type].Value, new Vector2(i * 16 - (int)Main.screenPosition.X - 8, j * 16 - (int)Main.screenPosition.Y - 8) + zero, value2, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}