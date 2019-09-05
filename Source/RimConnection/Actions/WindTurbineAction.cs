﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class WindTurbineAction : Action
    {
        public WindTurbineAction()
        {
            this.name = "Wind Turbine";
            this.description = "You spin me right round baby, right round, round round";
        }

        public override void execute(int amount)
        {
            DropPodManager.createDrop(ThingDefOf.WindTurbine, amount);
        }
    }
}
