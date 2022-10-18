using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace AModAboutSomething.Items.Tools.Hammer
{
    public class FoundationJackhammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("the Jackhammer the foundation uses for safe scp transportation");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 27;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.value = Item.buyPrice(gold: 10);
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = new SoundStyle($"{nameof(AModAboutSomething)}/Sounds/JackhammerSound");
            Item.autoReuse = true;

            Item.hammer = 500;
        }
    }
}
