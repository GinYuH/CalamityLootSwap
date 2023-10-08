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
	public class BrimMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Brimstone Elemental Manipulator");
				// Tooltip.SetDefault("Use this to switch between Brimstone Elemental loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 4;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Gehenna").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrimstoneSlag").Type, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.Register();
				}
				
			}
		}
	}
}