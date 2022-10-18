using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AModAboutSomething.Items.SCPS
{
    public class ScpTwoOSeven : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Scp 207 this will give you a slight speed boost.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

            ItemID.Sets.DrinkParticleColors[Type] = new Color[3] {
                new Color(240, 240, 240),
                new Color(200, 200, 200),
                new Color(140, 140, 140)
            };
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 18;
            Item.useTime = 18;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(gold: 15);
            Item.buffType = ModContent.BuffType<Effects.Buffs.TwoOSevenSpeed>();
            Item.buffTime = 200000;
        }
    }
}