using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Spells
{
    public interface ISpell
    {
        int Duration
        {
            get;
        }

        int Level
        {
            get;
        }

        int ManaCost
        {
            get;
        }

        string Name
        {
            get;
        }

        SpellType Type
        {
            get;
        }

        void CastAt(CombatGroup targets, Entity Caster);
    }
}
