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
	public class ClamMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Calamitas Manipulator");
				// Tooltip.SetDefault("Use this to switch between Calamitas loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 5;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamityRing").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamityDust").Type, 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
				}
			}
		}
	}
}