using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using AModAboutSomething.Items.materials;

namespace AModAboutSomething.Items.SCPS.Documents
{
    public class ScpFiveHundredDocument : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 500 Document");
            Tooltip.SetDefault("Scp 500 is a collective of pills that when taken will heal any disease in 2-3 hours");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(gold: 1);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<EmptyDocument>()
                .AddTile<Items.Tiles.Stations.DocumentStationTile>()
                .Register();
        }
            }
        }
   