using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.DivineSpells
{
    public class CureWounds : HealingSTSpell
    {
        public CureWounds() : base("Cure Wounds", 2, new DivineSpell())
        {
            maxLevel = 4;
            HealingDice = new Dice.Die[] { Dice.D8.GetInstance() };
            HealingBonus = 1;
        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(maxLevel, caster.CastingLevel);
        }
    }
}
