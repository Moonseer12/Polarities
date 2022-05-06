﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Polarities.Buffs;

namespace Polarities.Items.Books
{
    public class SkeletronBook : BookBase
    {
        public override int BuffType => BuffType<SkeletronBookBuff>();
    }

    public class SkeletronBookBuff : BookBuffBase
    {
        public override int ItemType => ItemType<SkeletronBook>();

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PolaritiesPlayer>().skeletronBook = true;
            if (player.GetModPlayer<PolaritiesPlayer>().skeletronBookCooldown == 0)
            {
                player.statDefense += 72;
            }

            base.Update(player, ref buffIndex);
        }
    }
}