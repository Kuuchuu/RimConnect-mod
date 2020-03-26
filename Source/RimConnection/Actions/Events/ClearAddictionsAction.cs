﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class ClearAddictionsAction : Action
    {
        public ClearAddictionsAction()
        {
            Name = "Clear Addictions";
            Description = "All the colonist will suddenly feel free";
            Category = "Event";
        }

        public override void Execute(int amount)
        {
            var colonists = Find.ColonistBar.GetColonistsInOrder();

            colonists.ForEach(colonist =>
            {
                colonist.health.hediffSet.GetHediffs<Hediff_Addiction>().ToList().ForEach(hediff => { colonist.health.RemoveHediff(hediff); });
            });

            AlertManager.NormalEventNotification("Your viewers wanted to help you out this time and removed all addictions");
        }
    }
}