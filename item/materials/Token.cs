using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using AModAboutSomething.Items.SCPS.Tokens;

namespace AModAboutSomething.Items.materials
{
    public class Token : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("this is Used to make scp collectables.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 50;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 9999;
            Item.value = Item.buyPrice(copper: 50);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 2)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<ScpFiveHundredToken>());
                CreativeUI.ResearchItem(ModContent.ItemType<ScpTwoOSevenToken>());
                CreativeUI.ResearchItem(ModContent.ItemType<LevelZeroZeroFiveToken>());
            }
        }
    }
}