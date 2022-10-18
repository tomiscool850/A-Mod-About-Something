using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Microsoft.CodeAnalysis;

namespace AModAboutSomething.Items.materials
{
    public class LevelFourKeycard : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This Card is Owned by Very Special Persinal.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 2;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(gold: 95);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ChlorophyteBar, 5)
                .AddIngredient(ModContent.ItemType<LevelThreeKeycard>())
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<LevelOneKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelTwoKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelThreeKeycard>());
            }
        }
    }
}