using CSCD454_FinalProject.Entitys;
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
            targets.SetTarget(players[rand.Next(count)]);
        }

        public override EntityCommand GetAction(Entity issuer)
        {
            return new AttackCommand(issuer);
        }
    }
}
