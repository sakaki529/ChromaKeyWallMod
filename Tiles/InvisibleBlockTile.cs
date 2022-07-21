using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Tiles
{
    public class InvisibleBlockTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            DustType = -1;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Invisible Block");
            AddMapEntry(new Color(220, 220, 255), name);
            MinPick = 0;
        }
    }
}
