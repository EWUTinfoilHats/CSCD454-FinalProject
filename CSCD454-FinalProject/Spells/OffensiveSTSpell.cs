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
        public OffensiveSTSpell(string name, int level, SpellType type) : base(name, level, type)
        {
            DamageBonus = 0;
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
            int level = GetLevel(caster);
            for (int i = 0; i < level; i++)
            {
                foreach (var d in DamageDice)
                {
                    damage += d.Roll();
                }
                damage += DamageBonus;
            }
            return damage;
        }

        public override void CastAt(CombatGroup targets, Entity caster)
        {
            if (Type.DidFizzle(caster))
            {
                caster.PushUIString(caster.Name + " fizzled " + Name);
                return;
            }

            caster.RemoveMana(ManaCost);
            int damage = GetDamage(caster);
            targets.Target.RemoveHP(damage);
            caster.PushUIString(caster.Name + " did " + damage + " damage to " + targets.Target.Name);
        }

        public override string Description
        {
            get
            {

                return "A " + Name + " costing " + ManaCost + ", dealing " + GetDamageDiceAsString() + "+" + DamageBonus + ".";
            }
        }

        public string GetDamageDiceAsString()
        {
            IDictionary<Die, int> count = new Dictionary<Die, int>();
            foreach (Die d in DamageDice)
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
