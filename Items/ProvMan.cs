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
	public class ProvMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Providence Manipulator");
				// Tooltip.SetDefault("Use this to switch between Providence loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.Turquoise>();
        }
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UnholyEssence").Type, 30);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DivineGeode").Type, 2);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlazingCore").Type, 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.Register();
				}
			}
		}
	}
}