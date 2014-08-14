using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.DivineSpells
{
    public class InflictWounds : OffensiveSTSpell
    {
        public InflictWounds() : base("Inflict Wounds", 2, new DivineSpell())
        {
            maxLevel = 4;
            DamageDice = new Dice.Die[] { Dice.D8.GetInstance() };
            DamageBonus = 1;
        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(4, caster.CastingLevel);
        }
    }
}
