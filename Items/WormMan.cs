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
	public class WormMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("The Devourer of Gods Manipulator");
				// Tooltip.SetDefault("Use this to switch between The Devourer of Gods loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.CosmicPurple>();
        }
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CosmiliteBar").Type, 3);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("NebulousCore").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WeebMan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("NutMan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CeaselessMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
                recipe.Register();
				}
			}
		}
	}
}