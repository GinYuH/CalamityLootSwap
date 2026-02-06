using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLootSwap;

namespace CalamityLootSwap.Items
{
	public class WitchMan : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Supreme Calamitas Manipulator");
			// Tooltip.SetDefault("Use this to switch between Supreme Calamitas loot");
		}

		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.BurnishedAuric>();
        }
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
			{
				{
					Recipe recipe = CreateRecipe();
					recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Calamity").Type, 1);
					recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AshesofAnnihilation").Type, 3);
					recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
					recipe.Register();
				}
			}
		}
	}
}