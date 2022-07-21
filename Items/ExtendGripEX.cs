using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChromaKeyWallMod.Items
{
    public class ExtendGripEX : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Extend Grip+");
            Tooltip.SetDefault("Increases tile reach(+50)" +
                "\nGives some buffs.");
        }
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.value = 0;
            Item.rare = ItemRarityID.Yellow;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Player.tileRangeX += 50;
            Player.tileRangeY += 50;
            player.AddBuff(BuffID.Builder, 2);
            player.AddBuff(BuffID.Mining, 2);
        }
        public override void AddRecipes()
        {
            CreateRecipe().Register();
        }
    }
}