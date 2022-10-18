using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using AModAboutSomething.Items.Tiles;
using AModAboutSomething.Items.TileStuff;
using AModAboutSomething.Items.materials;

namespace AModAboutSomething.Items.TileStuff.StationTile
{
    public class TokenStation : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Token Station");
            Tooltip.SetDefault("A Station about tokens.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.createTile = ModContent.TileType<Items.Tiles.Stations.TokenStationTile>();

            Item.width = 28;
            Item.height = 14; 

            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 15;

            Item.maxStack = 99;
            Item.consumable = true;
            Item.value = 150;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WorkBench)
                .AddIngredient<Token>(5)
                .Register();
        }
    }
}