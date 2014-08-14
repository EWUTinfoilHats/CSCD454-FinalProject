using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Spells.ArcaneSpells
{
    public class Fireball : OffensiveAOESpell
    {
        public Fireball() : base("Fireball", 3, new ArcaneSpell())
        {
            maxLevel = 10;
            DamageDice = new Dice.Die[] { Dice.D6.GetInstance() };
        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(10, caster.CastingLevel);
        }
    }
}
