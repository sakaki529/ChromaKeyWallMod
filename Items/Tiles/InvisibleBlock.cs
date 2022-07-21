using ChromaKeyWallMod.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Items.Tiles
{
    public class InvisibleBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Invisible Block");
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 1;
            Item.useAnimation = 10;
            Item.rare = ItemRarityID.Blue;
            Item.value = 0;
            Item.createTile = ModContent.TileType<InvisibleBlockTile>();
            Item.consumable = false;
            Item.tileBoost += 50;
        }
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}