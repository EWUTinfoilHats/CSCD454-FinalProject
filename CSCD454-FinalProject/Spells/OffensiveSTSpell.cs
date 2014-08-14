using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Spells
{
    public abstract class OffensiveSTSpell : AbstractSpell
    {
        public OffensiveSTSpell(string name, int manaCost, int level, SpellType type) : base(name, manaCost, level, type)
        {

        }
 
        public IList<Die> DamageDice
        {
            get;
            protected set;
        }

        public int DamageBonus
        {
            get;
            protected set;
        }

        protected virtual int GetDamage(Entity caster)
        {
            int damage = 0;
            foreach(Die d in DamageDice)
            {
                damage += d.Roll();
            }
            return damage + DamageBonus;
        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;
            targets.Target.RemoveHP(GetDamage(caster));
        }
    }
}
