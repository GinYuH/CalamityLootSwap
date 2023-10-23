using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLootSwap;
using CalamityMod.Items.Accessories;

namespace CalamityLootSwap.Items 
{
	public class BoomerMan : ModItem
	{
		public override void SetStaticDefaults()
			{
				// DisplayName.SetDefault("Old Duke Manipulator");
				// Tooltip.SetDefault("Use this to switch between Old Duke loot");
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
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CorrodedFossil").Type, 5);
				recipe.AddIngredient(ModContent.ItemType<OldDukeScales>(), 1);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.Register();
				}
			}
		}
	}
}