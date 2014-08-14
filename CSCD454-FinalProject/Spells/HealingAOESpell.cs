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
        public HealingAOESpell(string name, int level, SpellType type) : base(name, level, type)
        {

        }

        public override void CastAt(CombatGroup targets, Entitys.Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;

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
            int healing = GetHealing(caster);
            foreach (Entity e in actualTargets)
            {
                e.AddHP(healing);
                caster.PushUIString(e.Name + " healed " + healing + "hp by " + caster.Name);
            }
        }
    }
}
