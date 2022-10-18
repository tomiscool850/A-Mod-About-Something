using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace AModAboutSomething.Items.materials
{
    public class SuperSurger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Super duper epic.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 9999;
            Item.value = Item.buyPrice(gold: 1);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Surger>(), 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<Surger>());
                CreativeUI.ResearchItem(ModContent.ItemType<Cola>());
            }
        }
    }
}