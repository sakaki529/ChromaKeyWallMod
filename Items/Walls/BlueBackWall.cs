using Terraria.ID;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Items.Walls
{
    public class BlueBackWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Blue Screen");
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
            Item.createWall = ModContent.WallType<WallsTile.BlueBackWall>();
            Item.consumable = false;
            Item.tileBoost += 50;
        }
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}