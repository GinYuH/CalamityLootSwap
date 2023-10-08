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
	public class DeusMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Astrum Deus Manipulator");
				// Tooltip.SetDefault("Use this to switch between Astrum Deus loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 9;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Stardust").Type, 10);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HideofAstrumDeus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.Register();
				}
			}
		}
	}
}