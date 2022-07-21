using Terraria.ID;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Items.Walls
{
    public class RedBackWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Screen");
        }
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useTime = 1;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.rare = ItemRarityID.Blue;
            Item.createWall = ModContent.WallType<WallsTile.RedBackWall>();
            Item.consumable = false;
            Item.tileBoost += 50;
        }
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}