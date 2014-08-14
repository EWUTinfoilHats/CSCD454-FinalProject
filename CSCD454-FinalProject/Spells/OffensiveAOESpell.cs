using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Spells
{
    public abstract class OffensiveAOESpell : OffensiveSTSpell
    {
        public OffensiveAOESpell(string name, int manaCost, int level, SpellType type) : base(name, manaCost, level, type)
        {

        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;

            IList<Entity> actualTargets;
            if (targets.Players.Contains(caster))
            {
                actualTargets = targets.Monsters;
            }
            else
            {
                actualTargets = targets.Players;
            }
            int damage = GetDamage(caster);
            foreach(Entity e in actualTargets)
            {
                e.RemoveHP(damage);
            }
        }
    }
}
