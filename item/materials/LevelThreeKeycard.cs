using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Microsoft.CodeAnalysis;

namespace AModAboutSomething.Items.materials
{
    public class LevelThreeKeycard : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This card is owned by most persinal.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 2;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(gold: 25);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TitaniumBar, 5)
                .AddIngredient(ModContent.ItemType<LevelTwoKeycard>())
                .AddTile(TileID.MythrilAnvil)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.AdamantiteBar, 5)
                .AddIngredient(ModContent.ItemType<LevelTwoKeycard>())
                .AddTile(TileID.MythrilAnvil)
                .Register();

        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<LevelTwoKeycard>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelOneKeycard>());
            }
        }
    }
}