using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using AModAboutSomething.Items.materials;

namespace AModAboutSomething.Items.SCPS.Documents
{
    public class LevelZeroZeroFiveDocument : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 005 Document");
            Tooltip.SetDefault("scp 005 is a skeleton key that opens any door");
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
   