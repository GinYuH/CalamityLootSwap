using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using CalamityLootSwap.Items;
using System.Collections.Generic;
using System.Linq;
using static Terraria.ModLoader.ModContent;


namespace CalValEX
{
	public class Recipes : ModSystem
	{

		public override void AddRecipes()
		{
            #region aquascourge
            //Barinautical --> Stuff
            {
                Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//SubmarineShocker stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//DeepseaStaff stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Downpour Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//ScourgeoftheSeas Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinautical").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Downpour").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SubmarineShocker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DeepseaStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheSeas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("AquaMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region birb

			//RougeSlash --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GoldenEagle").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RougeSlash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GildedProboscis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RougeSlash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//GoldenEagle stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RougeSlash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GoldenEagle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GildedProboscis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GoldenEagle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//GildedProboscis Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RougeSlash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GildedProboscis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GoldenEagle").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GildedProboscis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BirbMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region boomer duke

			//ToxicantTwister --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//VitriolicViper stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//InsidiousImpaler stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//FetidEmesis Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//SepticSkewer Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//CadaverousCarrion Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ToxicantTwister").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FetidEmesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VitriolicViper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InsidiousImpaler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SepticSkewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CadaverousCarrion").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BoomerMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region brimmy
			//Brimlance --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//SeethingDischarge stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Abaddon Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Abaddon Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Brimlance").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeethingDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Abaddon").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DormantBrimseeker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("BrimMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region cv

			//Void Concentration Staff --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("MirrorBlade").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VoidConcentrationStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CeaselessMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//Mirror Blade --> stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("VoidConcentrationStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MirrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CeaselessMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region clone

			//TheEyeofCalamitas --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Animosity stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//BlightedEyeStaff stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//CalamitasInferno Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Animosity").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheEyeofCalamitas").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightedEyeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CalamitasInferno").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ClamMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region crabb

			//Mycoroot --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Fungicide stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//MycelialClaws stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Shroomerang Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//HyphaeRod Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Mycoroot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Shroomerang").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Fungicide").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("MycelialClaws").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HyphaeRod").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CrabMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region cryo
			//SnowstormStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//EffluviumBow stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Icebreaker Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Avalanche Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SnowstormStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EffluviumBow").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Icebreaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Avalanche").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("CryoMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region ds

			//Seabound Staff --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Aquatic Discharge stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Barinade stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Storm Spray Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//Sotd Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("SeaboundStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StormSpray").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AquaticDischarge").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Barinade").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ScourgeoftheDesert").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DesertMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region deus
			//TheMicrowave --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//StarSputter stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//Starfall stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//GodspawnHelixStaff Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//RegulusRiot Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheMicrowave").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("GodspawnHelixStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StarSputter").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Starfall").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RegulusRiot").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DeusMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region draedong
			//RefractionRotor --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//TheJailor stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//TheAtomSplitter stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//SpineOfThanatos Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//SurgeDriver Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//PhotonRipper Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			//AresExoskeleton Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RefractionRotor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpineOfThanatos").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheJailor").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheAtomSplitter").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SurgeDriver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhotonRipper").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AresExoskeleton").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("DraeMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("DraedonsForge").Type));
				recipe.Register();
			}
			#endregion
			#region levi

			//LureofEnthrallment --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Leviatitan stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Atlantis stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Greentide Stuff

			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//AnahitasArpeggio Stuff

			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//BrackishFlask Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//LeviathanTeeth Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//GastricBelcherStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LureofEnthrallment").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Greentide").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Leviatitan").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Atlantis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("AnahitasArpeggio").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BrackishFlask").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("LeviathanTeeth").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GastricBelcherStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("FishMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region polterchan
			//BansheeHook --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//FatesReveal stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//DaemonsFlame stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//EtherealSubjugator Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//GhastlyVisage Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//TerrorBlade Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//GhoulishGouger Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BansheeHook").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("EtherealSubjugator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FatesReveal").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DaemonsFlame").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhastlyVisage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TerrorBlade").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("GhoulishGouger").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("GhostMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region hivething

			//DankStaff --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//ShaderainStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//PerfectDark Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//Shadethrower Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//FilthyGlove Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DankStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PerfectDark").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShaderainStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Shadethrower").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FilthyGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("HiveMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			#endregion
			#region signut

			//CosmicKunai --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Cosmilamp").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CosmicKunai").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("NutMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//Cosmilamp stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CosmicKunai").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Cosmilamp").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("NutMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region oreo
			//Nebulash --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//BorealisBomber stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//AlulaAustralis stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//AuroradicalThrow stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//AuroraBlazer stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("Nebulash").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("BorealisBomber").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AlulaAustralis").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroradicalThrow").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AuroraBlazer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("OreoMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region perf
			//BloodClotStaff --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//Aorta stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//VeinBurster Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//Eviscerator Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//SausageMaker Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//BloodstainedGlove Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			//BloodBath
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodClotStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VeinBurster").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Aorta").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eviscerator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SausageMaker").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodstainedGlove").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodBath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PerfMan").Type, 1);
				recipe.AddTile(26);
				recipe.Register();
			}
			#endregion
			#region pbg
			//DiseasedPike --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//PlagueStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//PestilentDefiler stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//BlightSpewer Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//TheHive Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Pandemic Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//VirulentKatana Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//Malevolence
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//TheSyringe
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//FuelCellBundle
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//InfectedRemote
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DiseasedPike").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlightSpewer").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PlagueStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PestilentDefiler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheHive").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Pandemic").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("VirulentKatana").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Malevolence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheSyringe").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//InfectedRemote
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FuelCellBundle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("InfectedRemote").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("PlagueMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region provi
			//BlissfulBombardier --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//PurgeGuzzler stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//HolyCollider stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//MoltenAmputator Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//SolarFlare Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//TelluricGlare Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//DazzlingStabberStaff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BlissfulBombardier").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("MoltenAmputator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PurgeGuzzler").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("HolyCollider").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SolarFlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TelluricGlare").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DazzlingStabberStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ProvMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region packager
			//Hematemesis --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//CraniumSmasher stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//RealmRavager stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//SpikecragStaff Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//UltimusCleaver Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//BloodPact Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//FleshTotem Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Hematemesis").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("SpikecragStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("CraniumSmasher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("RealmRavager").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("UltimusCleaver").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("BloodPact").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FleshTotem").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("RavagerMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region giantclam
			//Poseidon --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//ClamorRifle stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//ShellfishStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			//ClamCrusher Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamorRifle").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Poseidon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ShellfishStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ClamCrusher").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("ShellMan").Type, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
			}
			#endregion
			#region slimegod
			//OverloadedBlaster --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//EldritchTome stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//CorroslimeStaff stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//CrimslimeStaff Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			//AbyssalTome Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("OverloadedBlaster").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CrimslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("EldritchTome").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("CorroslimeStaff").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("AbyssalTome").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("SlimeMan").Type, 1);
				recipe.AddTile(TileID.Anvils);
				recipe.Register();
			}
			#endregion
			#region vveaver
			//TheStorm --> Stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("TheStorm").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StormDragoon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WeebMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			//StormDragoon stuff
			{
				Recipe recipe = Recipe.Create((ModLoader.GetMod("CalamityMod").Find<ModItem>("StormDragoon").Type));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheStorm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WeebMan").Type, 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
			}
			#endregion
			#region scal
			//Vehemence --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Sacrifice stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Condemnation stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Violence Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Perdition Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Heresy Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			//Vigilance Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vehemence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Violence").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Sacrifice").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Condemnation").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Perdition").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Heresy").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Vigilance").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WitchMan").Type, 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type);
				recipe.Register();
			}
			#endregion
			#region DoG
			//Excelsus --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//Deathwind stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//DeathhailStaff stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//Eradicator Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//TheObliterator Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//StaffoftheMechworm Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Excelsus").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Eradicator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("Deathwind").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DeathhailStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheObliterator").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("StaffoftheMechworm").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("WormMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			#endregion
			#region yharon
			//YharonsKindleStaff --> Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//DragonsBreath stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//ChickenCannon stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//DragonRage Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//PhoenixFlameBarrage Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//ProfanedTrident Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//TheBurningSky Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			//FinalDawn Stuff
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("YharonsKindleStaff").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonRage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("DragonsBreath").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ChickenCannon").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("PhoenixFlameBarrage").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("ProfanedTrident").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
			{
				Recipe recipe = Recipe.Create(ModLoader.GetMod("CalamityMod").Find<ModItem>("TheBurningSky").Type);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("FinalDawn").Type, 1);
				recipe.AddIngredient(Mod.Find<ModItem>("YharonMan").Type, 1);
				recipe.AddTile((ModLoader.GetMod("CalamityMod").Find<ModTile>("CosmicAnvil").Type));
				recipe.Register();
			}
            #endregion
        }
    }
}