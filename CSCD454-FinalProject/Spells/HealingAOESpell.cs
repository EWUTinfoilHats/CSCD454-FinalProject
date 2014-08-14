using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Spells
{
    public abstract class HealingAOESpell : HealingSTSpell
    {
        public HealingAOESpell(string name, int manaCost, int level, SpellType type) : base(name, manaCost, level, type)
        {

        }

        public override void CastAt(CombatGroup targets, Entitys.Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;

            IList<Entity> actualTargets;
            if (targets.Players.Contains(caster))
            {
                actualTargets = targets.Players;
            }
            else
            {
                actualTargets = targets.Monsters;
            }
            int damage = GetHealing(caster);
            foreach (Entity e in actualTargets)
            {
                e.AddHP(damage);
            }
        }
    }
}
