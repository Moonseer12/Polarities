﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using Polarities.Items;
using Terraria.DataStructures;
using Terraria.Enums;
using Polarities.Dusts;

namespace Polarities.Tiles.AmbientTiles
{
	public class SaltAmbientTile1 : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.newTile.LavaDeath = false;

			TileObjectData.addTile(Type);

			DustType = DustType<SaltDust>();
			SoundType = 0;
			SoundStyle = 1;

			AddMapEntry(new Color(255, 190, 190));
		}
	}

	public class SaltAmbientTile2 : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.newTile.LavaDeath = false;

			TileObjectData.addTile(Type);

			DustType = DustType<SaltDust>();
			SoundType = 0;
			SoundStyle = 1;

			AddMapEntry(new Color(255, 190, 190));
		}
	}

	public class SaltAmbientTile3 : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.newTile.LavaDeath = false;

			TileObjectData.addTile(Type);

			DustType = DustType<SaltDust>();
			SoundType = 0;
			SoundStyle = 1;

			AddMapEntry(new Color(255, 190, 190));
		}
	}

	public class SaltAmbientTile4 : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.newTile.LavaDeath = false;

			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, 1, 1);
			TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
			// This is so we can place from above.
			TileObjectData.newTile.Origin = new Point16(0, 0);

			TileObjectData.addTile(Type);

			DustType = DustType<SaltDust>();
			SoundType = 0;
			SoundStyle = 1;

			AddMapEntry(new Color(255, 190, 190));
		}
	}

	public class SaltAmbientTile5 : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.newTile.LavaDeath = false;

			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, 1, 1);
			TileObjectData.newTile.AnchorBottom = AnchorData.Empty;

			TileObjectData.addTile(Type);

			DustType = DustType<SaltDust>();
			SoundType = 0;
			SoundStyle = 1;

			AddMapEntry(new Color(255, 190, 190));
		}
	}
}