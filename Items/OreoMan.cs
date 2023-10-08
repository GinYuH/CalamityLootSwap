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
	public class OreoMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Astrum Aureus Manipulator");
				// Tooltip.SetDefault("Use this to switch between Astrum Aureus loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 6;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AureusCell").Type, 3);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GravistarSabaton").Type, 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
				}
			}
		}
	}
}
