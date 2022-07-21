using ChromaKeyWallMod.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Items.Tiles
{
    public class InvisiblePlatfrom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Invisible Platform");
        }
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 14;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 1;
            Item.useAnimation = 10;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.createTile = ModContent.TileType<InvisiblePlatform>();
            Item.consumable = false;
            Item.tileBoost += 50;
        }
        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ModContent.ItemType<InvisibleBlock>()).Register();
        }
    }
}