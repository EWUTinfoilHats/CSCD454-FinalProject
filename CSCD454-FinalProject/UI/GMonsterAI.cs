using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Entitys.Commands;
using System;
using System.Collections.Generic;

namespace CSCD454_FinalProject.UI
{
    public class GMonsterAI : GUserInteraction, MonsterAI
    {
        public override Entity GetTarget(IList<Entity> targets)
        {
            int count = targets.Count;
            Random rand = new Random();
            return targets[rand.Next(count)];
        }

        public override EntityCommand GetAction(Entity issuer)
        {
            return new AttackCommand(issuer);
        }
    }
}
