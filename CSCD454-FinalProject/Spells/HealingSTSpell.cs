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
        public HealingSTSpell(string name, int level, SpellType type) : base(name, level, type)
        {
            HealingBonus = 0;
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
            int damage = 0;
            int level = GetLevel(caster);
            for (int i = 0; i < level; i++)
            {
                foreach (var d in HealingDice)
                {
                    damage += d.Roll();
                }
                damage += HealingBonus;
            }
            return damage;
        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
                return;
            caster.RemoveMana(ManaCost);
            targets.Target.AddHP(GetHealing(caster));
        }

        public override string Description
        {
            get
            {
                return "A " + Name + " costing " + ManaCost + ", healing for " + GetHealingDiceAsString() + "+" + HealingBonus + ".";
            }
        }

        public virtual string GetHealingDiceAsString()
        {
            IDictionary<Die, int> count = new Dictionary<Die, int>();
            foreach (Die d in HealingDice)
            {
                if (!count.ContainsKey(d))
                {
                    count.Add(d, 1);
                }
                else
                {
                    count[d] += 1;
                }
            }

            string result = "";
            int tmp = 0;
            foreach (var kv in count)
            {
                if (tmp != 0)
                {
                    result += "+ ";
                }
                result += kv.Value + "" + kv.Key;
                tmp++;
            }

            return result;
        }
    }
}
