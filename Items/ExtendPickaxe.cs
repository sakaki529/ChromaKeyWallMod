using ChromaKeyWallMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChromaKeyWallMod.Items
{
    public class ExtendPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tile Eraser");
            Tooltip.SetDefault("On eraser mode, left click to delete tiles that from this mod" +
                "\nRight click to change tool types" +
                "\n-Type list-" +
                "\n Normal Pickaxe" +
                "\n [c/c8c8ff:Invisible Block Eraser]" +
                "\n [c/c8c8ff:Invisible Platform Eraser]");
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.damage = 0;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 0.001f;
            Item.useTime = 1;
            Item.useAnimation = 10;
            Item.rare = ItemRarityID.Yellow;
            Item.value = 0;
            Item.UseSound = SoundID.Item1;
            Item.pick = 50;
            Item.tileBoost += 50;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            ChromaKeyWallPlayer modPlayer = player.GetModPlayer<ChromaKeyWallPlayer>();
            if (player.altFunctionUse == 2)
            {
                Item.useTime = 31;
                Item.useAnimation = 31;
                Item.pick = 0;
                if (modPlayer.TileEraserType == 0 && modPlayer.UseDelay == 0)
                {
                    modPlayer.TileEraserType = 1;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.TileEraserType == 1 && modPlayer.UseDelay == 0)
                {
                    modPlayer.TileEraserType = 2;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.TileEraserType == 2 && modPlayer.UseDelay == 0)
                {
                    modPlayer.TileEraserType = 0;
                    modPlayer.UseDelay += 10;
                }
            }
            else
            {
                if (modPlayer.TileEraserType == 0)
                {
                    Item.useTime = 2;
                    Item.useAnimation = 31;
                    Item.pick = 50;
                }
                else
                {
                    Item.useTime = 31;
                    Item.useAnimation = 31;
                    Item.pick = 0;
                }
            }
            return base.CanUseItem(player);
        }
        public override bool? UseItem(Player player)
        {
            ChromaKeyWallPlayer modPlayer = player.GetModPlayer<ChromaKeyWallPlayer>();
            if (player.altFunctionUse == 2)
            { }
            else
            {
                if (modPlayer.TileEraserType == 0)
                { }
                if (modPlayer.TileEraserType == 1)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].TileType == TileType<InvisibleBlockTile>())
                            {
                                WorldGen.KillTile(i, j, false, false, true);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
                if (modPlayer.TileEraserType == 2)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].TileType == TileType<InvisiblePlatform>())
                            {
                                WorldGen.KillTile(i, j, false, false, true);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        public override void HoldItem(Player player)
        {
            player.AddBuff(BuffID.Mining, 2);
        }
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}