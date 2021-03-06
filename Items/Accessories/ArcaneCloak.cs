﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PathOfTerraria.Items.Accessories
{
    class ArcaneCloak : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.GypsyRobe;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Take a portion of damage from your mana instead of health" +
                "\nIncrease your magic damage based on how much mana you have left" +
                "\nYou cannot gain mana when damaged (e.g. from the Magic Cuffs)");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.buyPrice(gold: 25);
            item.rare = ItemRarityID.Yellow;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<PathOfTerrariaPlayer>().arcaneCloak = true;
            player.GetModPlayer<PathOfTerrariaPlayer>().player.magicCuffs = false;
        }
    }
}
