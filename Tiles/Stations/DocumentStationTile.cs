using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using AModAboutSomething.Items.Tiles;
using AModAboutSomething.Items.TileStuff;

namespace AModAboutSomething.Items.Tiles.Stations
{
    public class DocumentStationTile : ModTile
    {
        public override void SetStaticDefaults()
        {
        
            Main.tileTable[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            AdjTiles = new int[] { TileID.WorkBenches };

        
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(Type);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

      
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Work Bench");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void NumDust(int x, int y, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, ModContent.ItemType<Items.TileStuff.StationTile.DocumentStation>());
        }
    }
}