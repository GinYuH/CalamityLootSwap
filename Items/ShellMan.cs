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
	public class ShellMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Giant Clam Manipulator");
				// Tooltip.SetDefault("Use this to switch between Hardmode Giant Clam loot");
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
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MolluskHusk").Type, 2);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GiantPearl").Type, 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
				}
				{
					Recipe recipe = CreateRecipe();
					recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MolluskHusk").Type, 2);
					recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AmidiasPendant").Type, 1);
					recipe.AddTile(TileID.MythrilAnvil);
					recipe.Register();
				}
			}
		}
	}
}