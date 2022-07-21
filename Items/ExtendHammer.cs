using ChromaKeyWallMod.WallsTile;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ChromaKeyWallMod.Items
{
    public class ExtendHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall Eraser");
            Tooltip.SetDefault("On eraser mode, left click to delete walls that from this mod" +
                "\n-Type list-" +
                "\n Normal Hammer" +
                "\n [c/ff0000:Red Screen Eraser]" +
                "\n [c/00ff00:Green Screen Eraser]" +
                "\n [c/0000ff:Blue Screen Eraser]" +
                "\n [c/ffff00:Yellow Screen Eraser]" +
                "\n [c/ffffff:White Screen Eraser]");
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
            Item.hammer = 50;
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
                Item.hammer = 0;
                if (modPlayer.WallEraserType == 0 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 1;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.WallEraserType == 1 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 2;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.WallEraserType == 2 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 3;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.WallEraserType == 3 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 4;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.WallEraserType == 4 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 5;
                    modPlayer.UseDelay += 10;
                }
                if (modPlayer.WallEraserType == 5 && modPlayer.UseDelay == 0)
                {
                    modPlayer.WallEraserType = 0;
                    modPlayer.UseDelay += 10;
                }
            }
            else
            {
                if (modPlayer.WallEraserType == 0)
                {
                    Item.useTime = 2;
                    Item.useAnimation = 31;
                    Item.hammer = 50;
                }
                else
                {
                    Item.useTime = 31;
                    Item.useAnimation = 31;
                    Item.hammer = 0;
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
                if (modPlayer.WallEraserType == 0)
                { }
                if (modPlayer.WallEraserType == 1)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].WallType == WallType<RedBackWall>())
                            {
                                WorldGen.KillWall(i, j, false);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
                if (modPlayer.WallEraserType == 2)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].WallType == WallType<GreenBackWall>())
                            {
                                WorldGen.KillWall(i, j, false);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
                if (modPlayer.WallEraserType == 3)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].WallType == WallType<BlueBackWall>())
                            {
                                WorldGen.KillWall(i, j, false);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
                if (modPlayer.WallEraserType == 4)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].WallType == WallType<YellowBackWall>())
                            {
                                WorldGen.KillWall(i, j, false);
                                if (WorldGen.InWorld(i, j))
                                {
                                    Main.Map.Update(i, j, 255);
                                }
                            }
                        }
                    }
                }
                if (modPlayer.WallEraserType == 5)
                {
                    for (int i = 0; i < Main.maxTilesX; i++)
                    {
                        for (int j = 0; j < Main.maxTilesY; j++)
                        {
                            if (Main.tile[i, j].WallType == WallType<WhiteBackWall>())
                            {
                                WorldGen.KillWall(i, j, false);
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
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}