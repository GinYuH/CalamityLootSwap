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
	public class SlimeMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Slime God Manipulator");
				// Tooltip.SetDefault("Use this to switch between Slime God loot");
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
                recipe.AddIngredient(ItemID.Gel, 100);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ManaOverloader").Type, 1);
                recipe.AddTile(TileID.Anvils);
                recipe.Register();
				}
			}
		}
	}
}