using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLootSwap;
using CalamityLootSwap.Items;

namespace CalamityLootSwap
{
	public class CalamityNpcDrops : GlobalNPC
	{
		public override void OnKill(NPC npc)
		{
			Mod mod = ModLoader.GetMod("CalamityMod");
			if (mod == null)
			{
				return;
			}
			if (!Main.expertMode)
			{
				if (npc.type == mod.Find<ModNPC>("DesertScourgeHead").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<DesertMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Crabulon").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<CrabMan>());
				}
				if (npc.type == mod.Find<ModNPC>("HiveMind").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<HiveMan>());
				}
				if (npc.type == mod.Find<ModNPC>("PerforatorHive").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<PerfMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("SlimeGodCore").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitEbonianSlimeGod").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitCrimulanSlimeGod").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<SlimeMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitEbonianSlimeGod").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SlimeGodCore").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitCrimulanSlimeGod").Type) && NPC.CountNPCS(mod.Find<ModNPC>("SplitEbonianSlimeGod").Type) == 1)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<SlimeMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitCrimulanSlimeGod").Type && NPC.CountNPCS(mod.Find<ModNPC>("SplitCrimulanSlimeGod").Type) == 1 && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SplitEbonianSlimeGod").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("SlimeGodCore").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<SlimeMan>());
				}
				if (npc.type == mod.Find<ModNPC>("OldDuke").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<BoomerMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Cryogen").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<CryoMan>());
				}
				if (npc.type == mod.Find<ModNPC>("AquaticScourgeHead").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<AquaMan>());
				}
				if (npc.type == mod.Find<ModNPC>("BrimstoneElemental").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<BrimMan>());
				}
				if (npc.type == mod.Find<ModNPC>("CalamitasClone").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<ClamMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Leviathan").Type && !NPC.AnyNPCs(mod.Find<ModNPC>("Anahita").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<FishMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Anahita").Type && !NPC.AnyNPCs(mod.Find<ModNPC>("Leviathan").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<FishMan>());
				}
				if (npc.type == mod.Find<ModNPC>("PlaguebringerGoliath").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<PlagueMan>());
				}
				if (npc.type == mod.Find<ModNPC>("RavagerBody").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<RavagerMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Bumblefuck").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<BirbMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Providence").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<ProvMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Polterghast").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<GhostMan>());
				}
				if (npc.type == mod.Find<ModNPC>("StormWeaverHead").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<WeebMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Signus").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<NutMan>());
				}
				if (npc.type == mod.Find<ModNPC>("CeaselessVoid").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<CeaselessMan>());
				}
				if (npc.type == mod.Find<ModNPC>("DevourerofGodsHead").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<WormMan>());
				}
				if (npc.type == mod.Find<ModNPC>("AstrumAureus").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<OreoMan>());
				}
				if (npc.type == mod.Find<ModNPC>("Yharon").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<YharonMan>());
				}
				if (npc.type == mod.Find<ModNPC>("GiantClam").Type && Main.hardMode)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<ShellMan>());
				}
				if (npc.type == mod.Find<ModNPC>("AstrumDeusHead").Type && NPC.CountNPCS(mod.Find<ModNPC>("AstrumDeusHead").Type) == 1)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<DeusMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("SupremeCalamitas").Type)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<WitchMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<DraeMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<DraeMan>());
				}
				if (npc.type == ModLoader.GetMod("CalamityMod").Find<ModNPC>("ThanatosHead").Type && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("AresBody").Type) && !NPC.AnyNPCs(ModLoader.GetMod("CalamityMod").Find<ModNPC>("Apollo").Type))
				{
					Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<DraeMan>());
				}
			}
		}
	}
}