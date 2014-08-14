using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.ArcaneSpells
{
    public class MagicMissle : OffensiveSTSpell
    {
        public MagicMissle() : base("Magic Missle", 1, new ArcaneSpell())
        {
            maxLevel = 5;
            DamageDice = new Dice.Die[] { Dice.D4.GetInstance() };
            DamageBonus = 1;
        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(5, caster.CastingLevel / 2 + 1);
        }
    }
}
