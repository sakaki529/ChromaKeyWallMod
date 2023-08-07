using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.WallsTile
{
    public class YellowBackWall : ModWall
    {
        public override void SetStaticDefaults()
        {
            Main.wallHouse[Type] = true;
            AddMapEntry(new Color(255, 255, 0));
            DustType = -1;
            RegisterItemDrop(-1);
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            ChromaKeyWallMethod.DrawWalls(i, j);
            return false;
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            if (ChromaKeyWallMod.ClientConfig.WallLighting)
            {
                float num = ChromaKeyWallMod.ClientConfig.IntensityFloat;
                r = num;
                g = num;
                b = num;
            }
        }
    }
}
