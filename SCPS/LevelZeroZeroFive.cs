using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace AModAboutSomething.Items.SCPS
{
    public class LevelZeroZeroFive : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scp 005");
            Tooltip.SetDefault("a skeleton key.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 1;
            Item.value = Item.buyPrice(platinum: 50); 
        }

       
        public override void AddRecipes()
        {
            CreateRecipe(999)
                .AddIngredient(ItemID.Keybrand)
                .AddIngredient(ItemID.BoneKey)
                .AddIngredient(ItemID.CorruptionKey)
                .AddIngredient(ItemID.CosmicCarKey)
                .AddIngredient(ItemID.CrimsonKey)
                .AddIngredient(ItemID.DungeonDesertKey)
                .AddIngredient(ItemID.FrozenKey)
                .AddIngredient(ItemID.GoldenKey)
                .AddIngredient(ItemID.HallowedKey)
                .AddIngredient(ItemID.JungleKey)
                .AddIngredient(ItemID.LightKey)
                .AddIngredient(ItemID.NightKey)
                .AddIngredient(ItemID.ShadowKey)
                .AddIngredient(ItemID.TempleKey)
                .AddIngredient(ItemID.OrnateShadowKey)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ItemID.Keybrand);
                CreativeUI.ResearchItem(ItemID.BoneKey);
                CreativeUI.ResearchItem(ItemID.CorruptionKey);
                CreativeUI.ResearchItem(ItemID.CorruptionKeyMold);
                CreativeUI.ResearchItem(ItemID.CosmicCarKey);
                CreativeUI.ResearchItem(ItemID.CrimsonKey);
                CreativeUI.ResearchItem(ItemID.CrimsonKeyMold);
                CreativeUI.ResearchItem(ItemID.DungeonDesertKey);
                CreativeUI.ResearchItem(ItemID.FrozenKey);
                CreativeUI.ResearchItem(ItemID.FrozenKeyMold);
                CreativeUI.ResearchItem(ItemID.GoldenKey);
                CreativeUI.ResearchItem(ItemID.HallowedKey);
                CreativeUI.ResearchItem(ItemID.HallowedKeyMold);
                CreativeUI.ResearchItem(ItemID.JungleKey);
                CreativeUI.ResearchItem(ItemID.JungleKeyMold);
                CreativeUI.ResearchItem(ItemID.LightKey);
                CreativeUI.ResearchItem(ItemID.NightKey);
                CreativeUI.ResearchItem(ItemID.OrnateShadowKey);
                CreativeUI.ResearchItem(ItemID.ShadowKey);
                CreativeUI.ResearchItem(ItemID.TempleKey);
            }
        }
    }
}