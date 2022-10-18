using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using AModAboutSomething.Items.materials;

namespace AModAboutSomething.Items.SCPS.Tokens
{
    public class LevelZeroZeroFiveToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 005 Token");
            Tooltip.SetDefault("good yob.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 10;
            Item.value = Item.buyPrice(gold: 1);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Token>()
                .AddTile<Items.Tiles.Stations.TokenStationTile>()
                .Register();
        }

            }
        }
   