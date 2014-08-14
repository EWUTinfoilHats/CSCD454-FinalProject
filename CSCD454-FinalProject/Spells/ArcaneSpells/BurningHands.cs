using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.ArcaneSpells
{
    public class BurningHands : OffensiveSTSpell
    {
        public BurningHands() : base("Burning Hands", 1, new ArcaneSpell())
        {
            DamageDice = new Dice.Die[] { Dice.D4.GetInstance() };
            maxLevel = 5;
        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(maxLevel, caster.CastingLevel);
        }
    }
}
