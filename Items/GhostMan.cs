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
	public class GhostMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Polterghast Manipulator");
				// Tooltip.SetDefault("Use this to switch between Polterghast loot");
			}
		
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 5000;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.PureGreen>();
        }
		public override void AddRecipes()
		{
			Mod CalamityLootSwap = ModLoader.GetMod("CalamityMod");
            {
				{
                Recipe recipe = CreateRecipe();
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RuinousSoul").Type, 2);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Affliction").Type, 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Phantoplasm").Type, 20);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.Register();
				}
			}
		}
	}
}