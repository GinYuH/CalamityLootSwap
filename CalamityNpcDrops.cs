using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityLootSwap;
using CalamityLootSwap.Items;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.Leviathan;
using Terraria.GameContent.ItemDropRules;
using CalamityMod.Items.Accessories;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.Yharon;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.ExoMechs.Apollo;

namespace CalamityLootSwap
{
	public class CalamityNpcDrops : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == ModContent.NPCType<DesertScourgeHead>())
			{
				npcLoot.AddNormalOnly(ModContent.ItemType<DesertMan>());
            }
            if (npc.type == ModContent.NPCType<Crabulon>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<CrabMan>());
            }
            if (npc.type == ModContent.NPCType<GiantClam>())
            {
                npcLoot.AddIf(()=> Main.hardMode && !Main.expertMode, ModContent.ItemType<ShellMan>());
            }
            if (npc.type == ModContent.NPCType<PerforatorHive>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<PerfMan>());
            }
            if (npc.type == ModContent.NPCType<HiveMind>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<HiveMan>());
            }
            if (npc.type == ModContent.NPCType<SlimeGodCore>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<SlimeMan>());
            }
            if (npc.type == ModContent.NPCType<Cryogen>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<CryoMan>());
            }
            if (npc.type == ModContent.NPCType<BrimstoneElemental>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<BrimMan>());
            }
            if (npc.type == ModContent.NPCType<AquaticScourgeHead>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<AquaMan>());
            }
            if (npc.type == ModContent.NPCType<CalamitasClone>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<ClamMan>());
            }
            if (npc.type == ModContent.NPCType<Leviathan>() || npc.type == ModContent.NPCType<Anahita>())
            {
                LeadingConditionRule mainRule = npcLoot.DefineConditionalDropSet(Leviathan.LastAnLStanding);
                LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.NotExpert());
                mainRule.Add(leadingConditionRule);
                leadingConditionRule.Add(ModContent.ItemType<FishMan>());
            }
            if (npc.type == ModContent.NPCType<AstrumAureus>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<OreoMan>());
            }
            if (npc.type == ModContent.NPCType<PlaguebringerGoliath>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<PlagueMan>());
            }
            if (npc.type == ModContent.NPCType<RavagerBody>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<RavagerMan>());
            }
            if (npc.type == ModContent.NPCType<AstrumDeusHead>())
            {
                LeadingConditionRule mainRule = npcLoot.DefineConditionalDropSet((DropAttemptInfo info) => !AstrumDeusHead.ShouldNotDropThings(info.npc));
                LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.NotExpert());
                mainRule.Add(leadingConditionRule);
                leadingConditionRule.Add(ModContent.ItemType<DeusMan>());
            }
            if (npc.type == ModContent.NPCType<Bumblefuck>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<BirbMan>());
            }
            if (npc.type == ModContent.NPCType<Providence>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<ProvMan>());
            }
            if (npc.type == ModContent.NPCType<StormWeaverHead>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<WeebMan>());
            }
            if (npc.type == ModContent.NPCType<Signus>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<NutMan>());
            }
            if (npc.type == ModContent.NPCType<CeaselessVoid>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<CeaselessMan>());
            }
            if (npc.type == ModContent.NPCType<Polterghast>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<GhostMan>());
            }
            if (npc.type == ModContent.NPCType<OldDuke>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<BoomerMan>());
            }
            if (npc.type == ModContent.NPCType<DevourerofGodsHead>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<WormMan>());
            }
            if (npc.type == ModContent.NPCType<Yharon>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<YharonMan>());
            }
            if (npc.type == ModContent.NPCType<SupremeCalamitas>())
            {
                npcLoot.AddNormalOnly(ModContent.ItemType<WitchMan>());
            }
            if (npc.type == ModContent.NPCType<AresBody>() || npc.type == ModContent.NPCType<ThanatosHead>() || npc.type == ModContent.NPCType<Apollo>())
            {
                LeadingConditionRule mainRule = npcLoot.DefineConditionalDropSet(AresBody.CanDropLoot);
                LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.NotExpert());
                mainRule.Add(leadingConditionRule);
                leadingConditionRule.Add(ModContent.ItemType<DraeMan>());
            }
        }
	}
}