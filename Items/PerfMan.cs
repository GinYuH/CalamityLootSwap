﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLootSwap;

namespace CalamityLootSwap.Items 
{
	public class PerfMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Perforator Manipulator");
				// Tooltip.SetDefault("Use this to switch between Perforator loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 3;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodSample").Type, 30);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodyWormTooth").Type, 1);
                recipe.AddTile(26);
                recipe.Register();
				}
			}
		}
	}
}