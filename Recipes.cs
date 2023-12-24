using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using CalamityLootSwap.Items;
using System.Collections.Generic;
using System.Linq;
using static Terraria.ModLoader.ModContent;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Tiles.Furniture.CraftingStations;

namespace CalValEX
{
	public class Recipes : ModSystem
	{
        List<int> aquaItems = new List<int>
        {
            ItemType<SubmarineShocker>(),
            ItemType<Downpour>(),
            ItemType<Barinautical>(),
            ItemType<DeepseaStaff>(),
            ItemType<ScourgeoftheSeas>()
        };

        List<int> perfItems = new List<int>
        {
            ItemType<VeinBurster>(),
            ItemType<Eviscerator>(),
            ItemType<BloodBath>(),
            ItemType<FleshOfInfidelity>(),
            ItemType<Aorta>(),
            ItemType<SausageMaker>(),
            ItemType<BloodstainedGlove>(),
        };

        List<int> birbItems = new List<int>
        {
            ItemType<GildedProboscis>(),
            ItemType<GoldenEagle>(),
            ItemType<RougeSlash>(),
        };

        List<int> boomerItems = new List<int>
        {
            ItemType<InsidiousImpaler>(),
            ItemType<SepticSkewer>(),
            ItemType<VitriolicViper>(),
            ItemType<CadaverousCarrion>(),
            ItemType<ToxicantTwister>(),
            ItemType<MutatedTruffle>(),
            ItemType<FetidEmesis>(),
        };

        List<int> brimItems = new List<int>
        {
            ItemType<Brimlance>(),
            ItemType<DormantBrimseeker>(),
            ItemType<SeethingDischarge>(),
			ItemType<RoseStone>()
        };

        List<int> voidItems = new List<int>
        {
            ItemType<MirrorBlade>(),
            ItemType<VoidConcentrationStaff>()
        };

        List<int> cloneItems = new List<int>
        {
            ItemType<Animosity>(),
            ItemType<LashesofChaos>(),
            ItemType<Oblivion>(),
            ItemType<EntropysVigil>(),
        };

        List<int> crabItems = new List<int>
        {
            ItemType<MycelialClaws>(),
            ItemType<Fungicide>(),
            ItemType<HyphaeRod>(),
            ItemType<PuffShroom>(),
            ItemType<Mycoroot>(),
            ItemType<InfestedClawmerang>(),
        };

        List<int> cryoItems = new List<int>
        {
            ItemType<Avalanche>(),
            ItemType<SnowstormStaff>(),
            ItemType<HoarfrostBow>(),
            ItemType<Icebreaker>(),
        };

        List<int> desertItems = new List<int>
        {
            ItemType<BrittleStarStaff>(),
            ItemType<SaharaSlicers>(),
            ItemType<SandstreamScepter>(),
            ItemType<Barinade>(),
            ItemType<ScourgeoftheDesert>()
        };

        List<int> deusItems = new List<int>
        {
            ItemType<TheMicrowave>(),
            ItemType<StarSputter>(),
            ItemType<StarspawnHelixStaff>(),
            ItemType<StarShower>(),
            ItemType<RegulusRiot>(),
        };

        List<int> draedonItems = new List<int>
        {
            ItemType<TheAtomSplitter>(),
            ItemType<SurgeDriver>(),
            ItemType<SpineOfThanatos>(),
            ItemType<AtlasMunitionsBeacon>(),
            ItemType<RefractionRotor>(),
            ItemType<TheJailor>(),
            ItemType<AresExoskeleton>(),
            ItemType<PhotonRipper>(),
        };

        List<int> levItems = new List<int>
        {
            ItemType<Atlantis>(),
            ItemType<BrackishFlask>(),
            ItemType<Leviatitan>(),
            ItemType<LeviathanTeeth>(),
            ItemType<AnahitasArpeggio>(),
            ItemType<PearlofEnthrallment>(),
            ItemType<GastricBelcherStaff>(),
            ItemType<Greentide>(),
        };

        List<int> polterItems = new List<int>
        {
            ItemType<TerrorBlade>(),
            ItemType<GhastlyVisage>(),
            ItemType<EtherealSubjugator>(),
            ItemType<FatesReveal>(),
            ItemType<DaemonsFlame>(),
            ItemType<GhoulishGouger>(),
			ItemType<BansheeHook>()
        };

        List<int> hiveItems = new List<int>
        {
            ItemType<PerfectDark>(),
            ItemType<Shadethrower>(),
            ItemType<DankStaff>(),
            ItemType<ShaderainStaff>(),
            ItemType<FilthyGlove>(),
        };

        List<int> sigItems = new List<int>
        {
            ItemType<Cosmilamp>(),
            ItemType<CosmicKunai>()
        };

        List<int> oreoItems = new List<int>
        {
            ItemType<Nebulash>(),
            ItemType<AuroraBlazer>(),
            ItemType<AlulaAustralis>(),
            ItemType<BorealisBomber>(),
            ItemType<AuroradicalThrow>()
        };

        List<int> pbgItems = new List<int>
        {
            ItemType<PestilentDefiler>(),
            ItemType<Pandemic>(),
            ItemType<Virulence>(),
            ItemType<TheHive>(),
            ItemType<Malevolence>(),
            ItemType<InfectedRemote>(),
            ItemType<FuelCellBundle>(),
            ItemType<BlightSpewer>(),
			ItemType<PlagueStaff>(),
			ItemType<DiseasedPike>(),
			ItemType<TheSyringe>()
        };

        List<int> proviItems = new List<int>
        {
            ItemType<HolyCollider>(),
            ItemType<MoltenAmputator>(),
            ItemType<DazzlingStabberStaff>(),
            ItemType<PurgeGuzzler>(),
            ItemType<TelluricGlare>(),
            ItemType<SolarFlare>(),
            ItemType<BlissfulBombardier>(),
        };

        List<int> ravagerItems = new List<int>
        {
            ItemType<RealmRavager>(),
            ItemType<UltimusCleaver>(),
            ItemType<Hematemesis>(),
            ItemType<CraniumSmasher>(),
            ItemType<SpikecragStaff>()
        };

        List<int> clamItems = new List<int>
        {
            ItemType<Poseidon>(),
            ItemType<ShellfishStaff>(),
            ItemType<ClamCrusher>(),
            ItemType<ClamorRifle>()
        };

        List<int> slimeItems = new List<int>
        {
            ItemType<OverloadedBlaster>(),
            ItemType<AbyssalTome>(),
            ItemType<EldritchTome>(),
            ItemType<CorroslimeStaff>(),
            ItemType<CrimslimeStaff>()
        };

        List<int> weavieItems = new List<int>
        {
            ItemType<TheStorm>(),
            ItemType<StormDragoon>()
        };

        List<int> scalItems = new List<int>
        {
            ItemType<Violence>(),
            ItemType<Condemnation>(),
            ItemType<Heresy>(),
            ItemType<Perdition>(),
            ItemType<Vigilance>(),
            ItemType<Sacrifice>(),
            ItemType<Vehemence>()
        };

        List<int> dogItems = new List<int>
        {
            ItemType<StaffoftheMechworm>(),
            ItemType<Eradicator>(),
            ItemType<Excelsus>(),
            ItemType<DeathhailStaff>(),
            ItemType<Deathwind>(),
            ItemType<TheObliterator>()
        };

        List<int> yharonItems = new List<int>
        {
            ItemType<DragonRage>(),
            ItemType<TheBurningSky>(),
            ItemType<DragonsBreath>(),
            ItemType<ChickenCannon>(),
            ItemType<PhoenixFlameBarrage>(),
            ItemType<YharonsKindleStaff>(),
            ItemType<FinalDawn>(),
            ItemType<Wrathwing>(),
        };

        public static void ManipulatorRecipes(int manipulator, int tile, List<int> items)
		{
			for (int i = 0; i < items.Count; i++)
            {
				for (int j = 0; j < items.Count; j++)
				{
					if (items[i] != items[j])
					{
						Recipe recipe = Recipe.Create(items[i]);
						recipe.AddIngredient(items[j]);
						recipe.AddIngredient(manipulator);
						recipe.AddTile(tile);
						recipe.Register();
					}
				}
            }
		}

		public override void AddRecipes()
        {
            ManipulatorRecipes(ItemType<AquaMan>(), TileID.Anvils, aquaItems);
            ManipulatorRecipes(ItemType<PerfMan>(), TileID.DemonAltar, perfItems);
            ManipulatorRecipes(ItemType<BirbMan>(), TileID.LunarCraftingStation, birbItems);
            ManipulatorRecipes(ItemType<BoomerMan>(), TileID.LunarCraftingStation, boomerItems);
            ManipulatorRecipes(ItemType<BrimMan>(), TileID.Anvils, brimItems);
            ManipulatorRecipes(ItemType<CeaselessMan>(), TileID.LunarCraftingStation, voidItems);
            ManipulatorRecipes(ItemType<ClamMan>(), TileID.MythrilAnvil, cloneItems);
            ManipulatorRecipes(ItemType<CrabMan>(), TileID.Anvils, crabItems);
            ManipulatorRecipes(ItemType<CryoMan>(), TileID.IceMachine, cryoItems);
            ManipulatorRecipes(ItemType<DesertMan>(), TileID.Anvils, desertItems);
            ManipulatorRecipes(ItemType<DeusMan>(), TileID.LunarCraftingStation, deusItems);
            ManipulatorRecipes(ItemType<DraeMan>(), TileType<DraedonsForge>(), draedonItems);
            ManipulatorRecipes(ItemType<FishMan>(), TileID.MythrilAnvil, levItems);
            ManipulatorRecipes(ItemType<GhostMan>(), TileID.LunarCraftingStation, polterItems);
            ManipulatorRecipes(ItemType<HiveMan>(), TileID.DemonAltar, hiveItems);
            ManipulatorRecipes(ItemType<NutMan>(), TileID.LunarCraftingStation, sigItems);
            ManipulatorRecipes(ItemType<OreoMan>(), TileID.MythrilAnvil, oreoItems);
            ManipulatorRecipes(ItemType<PlagueMan>(), TileID.MythrilAnvil, pbgItems);
            ManipulatorRecipes(ItemType<ProvMan>(), TileID.LunarCraftingStation, proviItems);
            ManipulatorRecipes(ItemType<RavagerMan>(), TileID.MythrilAnvil, ravagerItems);
            ManipulatorRecipes(ItemType<ShellMan>(), TileID.Anvils, clamItems);
            ManipulatorRecipes(ItemType<SlimeMan>(), TileType<StaticRefiner>(), slimeItems);
            ManipulatorRecipes(ItemType<WeebMan>(), TileID.LunarCraftingStation, weavieItems);
            ManipulatorRecipes(ItemType<WitchMan>(), TileType<CosmicAnvil>(), scalItems);
            ManipulatorRecipes(ItemType<WormMan>(), TileType<CosmicAnvil>(), dogItems);
            ManipulatorRecipes(ItemType<YharonMan>(), TileType<CosmicAnvil>(), yharonItems);
        }
    }
}