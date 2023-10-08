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
	public class FishMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Leviathan Manipulator");
				// Tooltip.SetDefault("Use this to switch between Leviathan loot");
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
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Lumenyl").Type, 10);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanAmbergris").Type, 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
				}
			}
		}
	}
}