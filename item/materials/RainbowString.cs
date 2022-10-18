using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Microsoft.CodeAnalysis;
using AModAboutSomething.Items.SCPS.Documents;

namespace AModAboutSomething.Items.materials
{
    public class RainbowString : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("RainbowSting, colorful.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 9999;
            Item.value = Item.buyPrice(silver: 25);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cobweb, 4)
                .AddIngredient(ItemID.RainbowDye)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
 
            }
        }