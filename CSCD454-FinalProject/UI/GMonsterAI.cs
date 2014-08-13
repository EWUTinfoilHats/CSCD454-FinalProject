﻿using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Commands;
using System;
using System.Collections.Generic;

namespace CSCD454_FinalProject.UI
{
    public class GMonsterAI : GUserInteraction, MonsterAI
    {
        public override void GetTarget(CombatGroup targets)
        {
            IList<Entity> players = targets.Players;
            int count = players.Count;
            Random rand = new Random();
            int choice = rand.Next(count);
            while (!players[choice].IsDead())
                choice = rand.Next(count);
            targets.SetTarget(players[choice]);
        }

        public override EntityCommand GetAction(Entity issuer)
        {
            return new AttackCommand(issuer);
        }
    }
}
