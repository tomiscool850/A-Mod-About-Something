using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Microsoft.CodeAnalysis;

namespace AModAboutSomething.Items.materials
{
    public class LevelFiveKeycard : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This card is owned by 0-5.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 2;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(platinum: 10);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarBar, 5)
                .AddIngredient(ModContent.ItemType<LevelFourKeycard>())
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<LevelFourKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelThreeKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelOneKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelTwoKeycard>());
            }
        }
    }
}