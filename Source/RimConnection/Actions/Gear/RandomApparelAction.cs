﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class RandomApparelAction : Action
    {
        public RandomApparelAction()
        {
            this.name = "Random Apparel";
            this.description = "Clothing, armour, it's all the same to me";
            this.canSpawnMultiple = true;
            this.category = "Gear";
        }

        public override void execute(int amount)
        {
            var apparelThingDefs = DefDatabase<ThingDef>.AllDefs.Where(def => { return def.IsApparel; });

            var randomApparelDefList = apparelThingDefs.ToList().TakeRandom(amount);

            var apparelThings = randomApparelDefList.Select(apparelDef => { return ThingMaker.MakeThing(apparelDef); });
            
            DropPodManager.createDropOfThings(apparelThings.ToList(), name, description);
        }
    }
}