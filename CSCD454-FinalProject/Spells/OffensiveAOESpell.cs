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
        public OffensiveAOESpell(string name, int level, SpellType type) : base(name, level, type)
        {

        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
            {
                caster.PushUIString(caster.Name + " fizzled " + Name);
                return;
            }

            caster.RemoveMana(ManaCost);
            IList<Entity> actualTargets;
            if (targets.Players.Contains(targets.Target))
            {
                actualTargets = targets.Players;
            }
            else
            {
                actualTargets = targets.Monsters;
            }
            int damage = GetDamage(caster);
            foreach(Entity e in actualTargets)
            {
                targets.Target.RemoveHP(damage);
                caster.PushUIString(caster.Name + " did " + damage + " damage to " + targets.Target.Name);
            }
        }
    }
}
