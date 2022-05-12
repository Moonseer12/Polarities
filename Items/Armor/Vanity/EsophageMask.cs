﻿using Terraria.ModLoader;
using Terraria.ID;
using Polarities.NPCs;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.GameContent;
using ReLogic.Content;

namespace Polarities.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class EsophageMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            this.SetResearch(1);

            int equipSlotHead = Mod.GetEquipSlot(Name, EquipType.Head);
            ArmorIDs.Head.Sets.DrawHead[equipSlotHead] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}