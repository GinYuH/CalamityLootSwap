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
	public class DesertMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Desert Scourge Manipulator");
				// Tooltip.SetDefault("Use this to switch between Desert Scourge loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
			Item.rare = 2;
		}
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VictideBar").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("OceanCrest").Type, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.Register();
				}
			}
		}
	}
}