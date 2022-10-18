using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace AModAboutSomething.Items.SCPS
{
    public class ScpFiveHundredPill : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 500 Pill");
            Tooltip.SetDefault("Eat to be epic'");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;


            ItemID.Sets.FoodParticleColors[Item.type] = new Color[3] {
                new Color(249, 230, 136),
                new Color(152, 93, 95),
                new Color(174, 192, 192)
            };

            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {

            Item.DefaultToFood(22, 22, BuffID.WellFed3, 57600);
            Item.value = Item.buyPrice(0, 3);
            Item.rare = ItemRarityID.Blue;
            Item.healLife = 500;
            Item.healMana = 500;
        }

        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 3600);
        }
  
        }
    }