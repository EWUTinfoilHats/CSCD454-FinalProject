using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Spells
{
    public class ArcaneSpell : SpellType
    {
        public bool DidFizzle(Entity caster)
        {
            Die per = D100.GetInstance();
            if (per.Roll() < caster.ArcaneSpellFailureChance)
                return true;
            return false;
        }
    }
}
