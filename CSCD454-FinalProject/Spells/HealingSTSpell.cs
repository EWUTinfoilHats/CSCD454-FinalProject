using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Spells
{
    public abstract class HealingSTSpell : AbstractSpell
    {
        public HealingSTSpell(string name, int manaCost, int level, SpellType type) : base(name, manaCost, level, type)
        {

        }

        public IList<Die> HealingDice
        {
            get;
            protected set;
        }

        public int HealingBonus
        {
            get;
            protected set;
        }

        public virtual int GetHealing(Entity caster)
        {
            int healing = 0;
            foreach (Die d in HealingDice)
            {
                healing += d.Roll();
            }
            return healing + HealingBonus;
        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;

            targets.Target.AddHP(GetHealing(caster));
        }
    }
}
