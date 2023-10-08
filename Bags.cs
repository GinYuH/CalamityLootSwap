using System;
using System.Collections.Generic;
using CalamityLootSwap;
using CalamityLootSwap.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace CalamityLootSwap
{
    public class Bags : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void ModifyItemLoot(Item arg, ItemLoot itemLoot)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (arg.type == calamityMod.Find<ModItem>("DesertScourgeBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<DesertMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("CrabulonBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<CrabMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("PerforatorBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<PerfMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("HiveMindBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<HiveMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("SlimeGodBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<SlimeMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("AquaticScourgeBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<AquaMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("BrimstoneWaifuBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<BrimMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("CalamitasBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<ClamMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("CryogenBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<CryoMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("LeviathanBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<FishMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("AstrumAureusBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<OreoMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("PlaguebringerGoliathBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<PlagueMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("RavagerBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<RavagerMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("AstrumDeusBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<DeusMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("ProvidenceBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<ProvMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("DragonfollyBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<BirbMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("PolterghastBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<GhostMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("OldDukeBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<BoomerMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("DevourerofGodsBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<WormMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("YharonBag").Type)
            {
                        itemLoot.Add(new CommonDrop(ModContent.ItemType<YharonMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("SignusBag").Type)
            {
                itemLoot.Add(new CommonDrop(ModContent.ItemType<NutMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("CeaselessVoidBag").Type)
            {
                itemLoot.Add(new CommonDrop(ModContent.ItemType<CeaselessMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("StormWeaverBag").Type)
            {
                itemLoot.Add(new CommonDrop(ModContent.ItemType<WeebMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("SupremeCalamitasCoffer").Type)
            {
                itemLoot.Add(new CommonDrop(ModContent.ItemType<WitchMan>(), 1));
            }
            if (arg.type == calamityMod.Find<ModItem>("DraedonBag").Type)
            {
                itemLoot.Add(new CommonDrop(ModContent.ItemType<DraeMan>(), 1));
            }
        }
    }
}


