using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using AModAboutSomething.Items.SCPS;
using AModAboutSomething.Items.SCPS.Tokens;

namespace AModAboutSomething.Items.materials
{
    public class ScpFiveHundredBottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 500 Bottle");
            Tooltip.SetDefault("Right Click to get free pills!!!!!.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 10;
            Item.value = Item.buyPrice(gold: 10);
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
        

            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<ScpFiveHundredPill>()));
            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<ScpFiveHundredPill>()));
            itemLoot.Add(ItemDropRule.NotScalingWithLuck(ModContent.ItemType<ScpFiveHundredPill>()));



        }
    }
}



