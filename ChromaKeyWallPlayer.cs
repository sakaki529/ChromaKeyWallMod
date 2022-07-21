using ChromaKeyWallMod.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChromaKeyWallMod
{
    public class ChromaKeyWallPlayer : ModPlayer
    {
        public int UseDelay;
        public int TileEraserType;
        public int WallEraserType;
        public override void PreUpdate()
        {
            if (UseDelay > 0)
            {
                UseDelay -= 1;
            }
        }
        public override void PostUpdate()
        {
            if (Main.netMode != NetmodeID.Server)
            {
                if (TileEraserType == 0 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendPickaxe>())
                {
                    Main.NewText("Tile Eraser: Normal Pickaxe", 255, 255, 255);
                }
                else if (TileEraserType == 1 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendPickaxe>())
                {
                    Main.NewText("Tile Eraser: Invisible Block Eraser", 200, 200, 255);
                }
                else if (TileEraserType == 2 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendPickaxe>())
                {
                    Main.NewText("Tile Eraser: Invisible Platform Eraser", 200, 200, 255);
                }
                if (WallEraserType == 0 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: Normal Hammer", 255, 255, 255);
                }
                else if (WallEraserType == 1 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: Red Screen Eraser", 255, 0, 0);
                }
                else if (WallEraserType == 2 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: Green Screen Eraser", 0, 255, 0);
                }
                else if (WallEraserType == 3 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: Blue Screen Eraser", 0, 0, 255);
                }
                else if (WallEraserType == 4 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: Yellow Screen Eraser", 255, 255, 0);
                }
                else if (WallEraserType == 5 && UseDelay == 10 && Player.inventory[Player.selectedItem].type == ItemType<ExtendHammer>())
                {
                    Main.NewText("Wall Eraser: White Screen Eraser", 255, 255, 255);
                }
            }
        }
    }
}