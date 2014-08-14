using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Spells.ArcaneSpells
{
    public class ScorchingRay : OffensiveSTSpell
    {
        public ScorchingRay() : base("Scorching Ray", 2, new ArcaneSpell())
        {
            maxLevel = 3;
            IList<Die> damage = new List<Die>();
            for (int i = 0; i < 4; i++)
                damage.Add(D4.GetInstance());
            DamageDice = damage;

        }

        public override int GetLevel(Entitys.Entity caster)
        {
            return Math.Min(maxLevel, (caster.CastingLevel - 3) / 4 + 1);
        }
    }
}
