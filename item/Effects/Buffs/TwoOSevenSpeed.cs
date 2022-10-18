using Terraria;
using Terraria.ModLoader;

namespace AModAboutSomething.Items.Effects.Buffs
{
    public class TwoOSevenSpeed : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("207 Speed");
            Description.SetDefault("Gives the speed of 207.");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.accRunSpeed += 10;
            player.lifeRegen -= 15;
        }
    }
}