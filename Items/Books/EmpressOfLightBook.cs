﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Polarities.Buffs;
using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Microsoft.Xna.Framework.Graphics;

namespace Polarities.Items.Books
{
    public class EmpressOfLightBook : BookBase
    {
        public override int BuffType => BuffType<EmpressOfLightBookBuff>();
    }

    public class EmpressOfLightBookBuff : BookBuffBase
    {
        public override int ItemType => ItemType<EmpressOfLightBook>();

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PolaritiesPlayer>().critDamageBoostMultiplier *= 1.25f;
            player.GetModPlayer<PolaritiesPlayer>().ignoreCritDefenseAmount += 25;

            base.Update(player, ref buffIndex);
        }
    }
}